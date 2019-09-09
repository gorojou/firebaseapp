using System;
using System.Threading.Tasks;

namespace Beux.Services.FirebaseAuth
{
    public interface IFirebaseAuthService
    {
        string getAuthKey();
        bool IsUserSigned();
        Task<bool> SignUp(String email, String password);
        Task<bool> SignIn(String email, String password);
        void SignInWithGoogle();
        Task<bool> SignInWithGoogle(String token);
        Task<bool> Logout();

        string GetUserId();
    }
}