using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskOfCreateApi.Models;
using TaskOfCreateApi.Interfaces;

namespace TaskOfCreateApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserServiceInterface _IuserServiceInterface;

        public UserController(IUserServiceInterface IuserServiceInterface)
        {
            _IuserServiceInterface = IuserServiceInterface;
        }

        [HttpGet("counts")]
        public async Task<ActionResult<IEnumerable<CountsOfUserProjectCustomerTask>>> GetUserProjectCustomerTaskCounts()
        {
            var result = await _IuserServiceInterface.GetUserProjectCustomerTaskCountsAsync();
            return Ok(result);
        }
    }
}
