using robodoc.backend.Services.Interfaces;

namespace robodoc.backend.Services
{
    public class UserService : IUserService
    {
        public bool ValidateCredentials(string username, string password)
        {
            return username.Equals("admin") && password.Equals("password");
        }
    }
}
