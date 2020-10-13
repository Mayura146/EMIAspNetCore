using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DatingApp.DataModel.Context;
using DatingApp.DataModel.Entities;
using DatingApp.ServiceModel.DTOs.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly DatingAppDbContext _datingAppDbContext;

        public AccountController(DatingAppDbContext datingAppDbContext)
        {
            _datingAppDbContext = datingAppDbContext;
        }

        [HttpPost("register")]

        public async Task<ActionResult<RegisterDto>> Register(string name,string password)
        {
            if (await UserExists(name)) return BadRequest("UserName already Exists");

            var hmac= new HMACSHA512();
            var user = new User
            {
                Name = name,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                PasswordSalt = hmac.Key
            };

            _datingAppDbContext.User.Add(user);

            await _datingAppDbContext.SaveChangesAsync();
            var registerDto = new RegisterDto
            {
                UserName = name
                
            };
            return registerDto;

        }
        [HttpPost("login")]
        public async Task<ActionResult<LoginDto>> Login(string userName,string password)
        {
         
            if (!await UserExists(userName)) return Unauthorized("Invalid UserName");
            var user = await _datingAppDbContext.User.SingleOrDefaultAsync(u => u.Name == userName);
            var hmac = new HMACSHA512(user.PasswordSalt);
            var value = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
          
            if(!Enumerable.SequenceEqual(value,user.PasswordHash))
            {
                return Unauthorized("Invalid Password!!");
            }

            var loginDto = new LoginDto
            {
                UserName = userName
            };

            return loginDto;
          
        }
        private async Task<bool> UserExists(string userName)
        {
            return await _datingAppDbContext.User.AnyAsync(u => u.Name.ToLower() == userName.ToLower());
        }
    }
}
