using Microsoft.AspNetCore.Mvc;
using Nagp.UserInfo.Models;
using System.Collections;

namespace Nagp.UserInfo.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserDetailsController : Controller
    {
        private readonly NagpUserDbContext _context;
        public UserDetailsController(NagpUserDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("userinfo")]
        public IEnumerable<UserInformation> GetUserInfo()
        {
            var userInfo = _context.UserInformations;
            return userInfo;
        }
    }
}
