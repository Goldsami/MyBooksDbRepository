using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BLL.DTOs;
using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private IAuthorService _authorService;

        public AuthorController(IAuthorService service)
        {
            _authorService = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var authors = _authorService.GetAll();
                return Ok(authors);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                var author = _authorService.Get(id);

                if (author != null)
                {
                    return Ok(author);
                }
                else return StatusCode(204);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(AuthorDTO author)
        {
            try
            {
                await _authorService.CreateAsync(author);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(AuthorDTO author)
        {
            try
            {
                await _authorService.UpdateAsync(author);
                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _authorService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

    }
}
