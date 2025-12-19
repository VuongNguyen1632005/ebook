using System;
using System.Threading.Tasks;
using Azure;
using Azure.AI.Inference;
using System.Collections.Generic;

namespace WindowsFormsApp1.Services
{
    public class GitHubModelService
    {
        private string GITHUB_TOKEN = Properties.Settings.Default.GitHubToken;
        private const string MODEL_NAME = "Llama-4-Scout-17B-16E-Instruct";

        private readonly ChatCompletionsClient _client;

        public GitHubModelService()
        {
            var endpoint = new Uri("https://models.inference.ai.azure.com");
            var credential = new AzureKeyCredential(GITHUB_TOKEN);

            _client = new ChatCompletionsClient(endpoint, credential);
        }

        public async Task<string> AskAI(string contextText, string userPrompt)
        {
            try
            {
               
                string safeContext = contextText.Length > 15000
                    ? contextText.Substring(0, 15000)
                    : contextText;

                var requestOptions = new ChatCompletionsOptions()
                {
                    Messages =
            {
                new ChatRequestSystemMessage("Bạn là trợ lý đọc sách thông minh."),
                new ChatRequestUserMessage($"Nội dung sách:\n{safeContext}"),
                new ChatRequestUserMessage($"Câu hỏi: {userPrompt}")
            },
                    Model = MODEL_NAME,
                    Temperature = 0.7f,
                   
                    MaxTokens = 1000
                };

                var response = await _client.CompleteAsync(requestOptions);
                return response.Value.Content ?? "AI không trả về nội dung.";
            }
    

            catch (RequestFailedException ex)
            {
                if ((int)ex.Status == 429)
                    return "Lỗi: GitHub Models đang bận. Vui lòng thử lại sau vài giây.";

                return $"Lỗi API: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Lỗi hệ thống: {ex.Message}";
            }
        }
    }
}
