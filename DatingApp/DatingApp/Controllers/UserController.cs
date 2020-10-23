using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DatingApp.Api.Extensions;
using DatingApp.Api.Services.Interfaces;
using DatingApp.DataModel.Entities;
using DatingApp.ServiceModel.DTOs.Request;
using DatingApp.ServiceModel.DTOs.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService,IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUserAsync()
        {
            //return await _userService.GetAllAsync();

            var user = await _userService.GetAllAsync();
            var response = _mapper.Map<IEnumerable<UserDto>>(user);
            return Ok(response);
        }


        [HttpGet("{Id}")]
        [Authorize]
        public async Task<ActionResult<UserDto>> GetUserByIdAsync(int Id)
        {
            var user= await _userService.GetByIdAsync(Id);
            var response = _mapper.Map<UserDto>(user);

            return response;
        }

        [HttpPut("update")]
        public async Task<ActionResult>UpdateUser(UserUpdateDto userUpdateDto)
        {
            var userId = await _userService.GetByIdAsync(User.GetUserId());
            //var user = await _userService.GetByIdAsync(id);
            var result = _mapper.Map(userUpdateDto, userId);
            _userService.Update(result);

            if (await _userService.SaveAllChangesAsync())
                return NoContent();

            return BadRequest("Updation Failed!!");
        }
    }
}