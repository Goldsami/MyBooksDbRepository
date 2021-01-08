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
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService service)
        {
            _bookService = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var books = _bookService.GetAll();
                return Ok(books);
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
                var book = _bookService.Get(id);

                if (book != null)
                {
                    return Ok(book);
                }
                else return StatusCode(204);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(BookDTO book)
        {
            try
            {
                await _bookService.CreateAsync(book);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(BookDTO book)
        {
            try
            {
                await _bookService.UpdateAsync(book);
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
                await _bookService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
