using EcommerceAPI.Data;
using EcommerceAPI.DTOs;
using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Services;
using System;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;

        public AuthController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDTO dto)
        {
            var user = await _userService.RegisterUserAsync(dto);
            if (user == null)
                return BadRequest("Email ya registrado");

            return Ok(new { user.Id, user.UserName, user.Email });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDTO dto)
        {
            var user = await _userService.AuthenticateAsync(dto);
            if (user == null)
                return Unauthorized("Credenciales inválidas");

            return Ok(new { message = "Login exitoso", user.Id, user.UserName });
        }
    }
}
