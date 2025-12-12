using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp1.Services
{
    /// <summary>
    /// Service tích h?p v?i Google Gemini AI
    /// </summary>
    public class GeminiService
    {
        // ?? Thay API Key M?I c?a b?n vào ðây (Key c? ð? b? l?, h?y xóa ði)
        private const string API_KEY = "AIzaSyDsJXnCt0OMttowASMb7gqtX3eRr-34uNc";

        // S? d?ng v1beta endpoint
        private const string API_URL = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent";

        /// <summary>
        /// H?i AI v? n?i dung sách
        /// </summary>
        public async Task<string> AskGemini(string contextText, string userPrompt)
        {
            try
            {
                var options = new RestClientOptions(API_URL);
                var client = new RestClient(options);
                var request = new RestRequest("");
                request.Method = Method.Post;

                request.AddQueryParameter("key", API_KEY);
                request.AddHeader("Content-Type", "application/json");

                // Gi?i h?n context 2,000,000 k? t? (Gemini Flash h? tr? context l?n)
                string safeContext = contextText.Length > 2000000 
                    ? contextText.Substring(0, 2000000) 
                    : contextText;

                string finalPrompt = $"D?a vào n?i dung sách sau:\n---\n{safeContext}\n---\nH?y tr? l?i câu h?i: {userPrompt}";

                var body = new
                {
                    contents = new[]
                    {
                        new
                        {
                            parts = new[]
                            {
                                new { text = finalPrompt }
                            }
                        }
                    }
                };

                request.AddJsonBody(body);
                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var jsonResponse = JObject.Parse(response.Content);
                    string aiReply = jsonResponse["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString();
                    return aiReply ?? "AI không tr? l?i (null).";
                }
                else
                {
                    return $"L?i API ({response.StatusCode}): {response.Content}";
                }
            }
            catch (Exception ex)
            {
                return $"L?i h? th?ng: {ex.Message}";
            }
        }
    }
}
