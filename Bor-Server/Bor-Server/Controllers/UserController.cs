using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Albina.BusinesLogic.Core.Interfaces;
using Bor.Core.Models;
using Bor.DataAccess.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bor_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IContext _context;
        private readonly IUserService _userService;

        public UserController(IContext context)
        {
            _context = context;
        }

        [HttpPost("/auth")]
        public async Task<ActionResult<UserInformationDto>> Auth([FromBody]UserIdentityDto userIdentityDto)
        {
            _userService.Auth();
        }

    }
}
