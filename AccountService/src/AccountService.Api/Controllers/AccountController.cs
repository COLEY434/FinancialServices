using AccountService.Api.Filters;
using AccountService.Core.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace AccountService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
          
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpPost("CreateAccount")]
        [ValidateModel]
        public async Task<object> CreateAccount([FromBody] AccountRequestDto req)
        {
            return Ok();
        }
    }
}