namespace robodoc.backend.Services.Interfaces
{
    public interface IUserService
    {
        bool ValidateCredentials(string username, string password);
    }
}
