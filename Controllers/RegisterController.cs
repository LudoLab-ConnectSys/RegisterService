
using Microsoft.AspNetCore.Mvc;
using RegisterService.Models;

namespace RegisterService.Controllers
{
    [Route("register")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly RegisterService.Services.RegisterService _registerService;

        public RegisterController(RegisterService.Services.RegisterService registerService)
        {
            _registerService = registerService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            try
            {
                await _registerService.CreateUserAsync(user);
                return CreatedAtAction(nameof(CreateUser), new { id = user.IdUsuario }, user);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("encrypt")]
        public IActionResult Encrypt([FromBody] string plainText)
        {
            try
            {
                var encryptedText = _registerService.Encrypt(plainText);
                return Ok(new { encryptedText });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("decrypt")]
        public IActionResult Decrypt([FromBody] string cipherText)
        {
            try
            {
                var decryptedText = _registerService.Decrypt(cipherText);
                return Ok(new { decryptedText });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}