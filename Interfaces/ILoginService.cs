using ST_API.Models;

namespace ST_API.Interfaces
{
    /// <summary>
    /// Service/LoginService.cs
    /// </summary>
    public interface ILoginService
    {
        /// <summary>
        /// Login 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <response code="200">ผ่าน</response>
        ResultLogin onLogin(LoginModels obj);
    }
}
