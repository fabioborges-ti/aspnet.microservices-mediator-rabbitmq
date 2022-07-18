using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _accountService.GetAccounts();

            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransfer accounTransfer)
        {
            _accountService.Transfer(accounTransfer);

            return Ok(accounTransfer);
        }
    }
}
