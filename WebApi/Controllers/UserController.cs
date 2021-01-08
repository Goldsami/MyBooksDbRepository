using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTOs;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService service)
        {
            _userService = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var users = _userService.GetAll();
                return Ok(users);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                var user = _userService.Get(id);

                if (user != null)
                {
                    return Ok(user);
                }
                else return StatusCode(204);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(UserDTO user)
        {
            try
            {
                await _userService.CreateAsync(user);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(UserDTO user)
        {
            try
            {
                await _userService.UpdateAsync(user);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _userService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
