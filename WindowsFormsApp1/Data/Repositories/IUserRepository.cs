using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Data.Repositories
{
    /// <summary>
    /// Interface cho User Repository
    /// </summary>
    public interface IUserRepository
    {
        User Login(string username, string password);
        User Register(string username, string password, string displayName, string email);
        User GetUserById(int userId);
        
        bool IsUserExists(string username);
        bool VerifyCurrentPassword(int userId, string password);
        
        void UpdateUserProfile(int userId, string displayName, string email, string newPassword = null);
        void UpdateUserTheme(int userId, string theme);
        string GetUserTheme(int userId);
    }
}
