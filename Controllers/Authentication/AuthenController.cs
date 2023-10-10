using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ST_API.Interfaces;
using ST_API.Models;

namespace ST_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {
        private readonly ILoginService _ILoginService;
        public AuthenController(ILoginService iLoginService)
        {
            this._ILoginService = iLoginService;
        }
        /// <summary>
        /// เข้าสู่ระบบ
        /// </summary>
        /// <param name="objLogin"></param>
        /// <response code="200">ผ่าน</response>
        /// <response code="401">ไม่ผ่าน</response>
        /// <response code="500">Internal Server Error Check Log</response>
        [HttpGet]
        // [ValidateAntiForgeryToken]
        public IActionResult onLogin([FromQuery] LoginModels objLogin)
        {
            var res = this._ILoginService.onLogin(objLogin);
            return Ok(res);
        }

        // [HttpPost]
        // [Authorize]
        // public IActionResult checkAntifogery()
        // {
        //     return Ok("");
        // }
    }
}
