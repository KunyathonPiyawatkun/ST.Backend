using ST_API.Models.AuthenticationModels;

namespace ST_API.Interfaces
{
    public interface IAuthentication
    {
        string BuildToken(TokenJWTSecret jWTSecret);
        bool IsHasExists();
        TokenJWTSecret GetUserAccount();
    }
}
