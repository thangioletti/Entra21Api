using Microsoft.AspNetCore.Mvc;
using MinhaApiBonita.Contracts.Repository;

namespace MinhaApiBonita.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userRepository.Get());
        }

    }
}
