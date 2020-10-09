using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Api.Services.Interfaces;
using DatingApp.DataModel.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUserAsync()
        {
            return await _userService.GetAllAsync();
        }


        [HttpGet("{Id}")]

        public async Task<User> GetUserByIdAsync(int Id)
        {
            return await _userService.GetByIdAsync(Id);
        }

    }
}