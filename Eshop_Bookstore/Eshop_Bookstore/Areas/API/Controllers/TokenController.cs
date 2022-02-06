using Eshop_Bookstore.Data;
using Eshop_Bookstore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_Bookstore.Areas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        public IConfiguration _configuration;
        public readonly Eshop_BookstoreContext _context;

        public TokenController(IConfiguration configuration, Eshop_BookstoreContext eshop_Bookstore)
        {
            _configuration = configuration;
            _context = eshop_Bookstore;
        }

        public async Task<IActionResult> Product(Account account)
        {
            if(account != null && account.Username != null && account.Password != null)
            {
                var user = await getUser(account.Username, account.Password);
                
                if(user != null)
                {                    
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("Id", account.Id.ToString()),
                        new Claim("UserName", user.Username),
                        new Claim("Password", user.Password)
                    };

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        _configuration["Jwt:Issuer"],
                        _configuration["Jwt:Audience"],
                        claims,
                        expires: DateTime.Now.AddMinutes(20),
                        signingCredentials: signIn);
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));
                }
                else
                {
                    return BadRequest("Invalid credentials");
                }

            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<Account> getUser(string userName, string pass)
        {
            return await _context.Accounts.FirstOrDefaultAsync(u => u.Username == userName && u.Password == pass);
        }

    }
}
