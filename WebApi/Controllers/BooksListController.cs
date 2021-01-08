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
    public class BooksListController : ControllerBase
    {
        private IBooksListService _booksListService;

        public BooksListController(IBooksListService service)
        {
            _booksListService = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var booksLists = _booksListService.GetAll();
                return Ok(booksLists);
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
                var booksList = _booksListService.Get(id);

                if (booksList != null)
                {
                    return Ok(booksList);
                }
                else return StatusCode(204);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(BooksListDTO booksList)
        {
            try
            {
                await _booksListService.CreateAsync(booksList);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(BooksListDTO booksList)
        {
            try
            {
                await _booksListService.UpdateAsync(booksList);
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
                await _booksListService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
