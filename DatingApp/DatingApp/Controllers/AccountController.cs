using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DatingApp.DataModel.Context;
using DatingApp.DataModel.Entities;
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

        public async Task<ActionResult<User>> Register(string name,string password)
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
            return user;
        }

        private async Task<bool> UserExists(string userName)
        {
            return await _datingAppDbContext.User.AnyAsync(u => u.Name.ToLower() == userName.ToLower());
        }
    }
}
