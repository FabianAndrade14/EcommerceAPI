using EcommerceAPI.Data;
using EcommerceAPI.DTOs;
using EcommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Services
{
    public class UserService
    {
        private readonly EcommerceContext _context;
        public UserService(EcommerceContext context) { _context = context; }
        public async Task<User?> RegisterUserAsync(UserRegisterDTO dto)
        {
            if (_context.Users.Any(u => u.Email == dto.Email)) return null;
            var user = new User
            {
                UserName = dto.Username,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User?> AuthenticateAsync(UserLoginDTO dto)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if(user is null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash)) return null;
            return user;
        }
    }
}
