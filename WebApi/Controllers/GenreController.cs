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
    public class GenreController : ControllerBase
    {
        private IGenreService _genreService;

        public GenreController(IGenreService service)
        {
            _genreService = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var genres = _genreService.GetAll();
                return Ok(genres);
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
                var genre = _genreService.Get(id);

                if (genre != null)
                {
                    return Ok(genre);
                }
                else return StatusCode(204);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(GenreDTO genre)
        {
            try
            {
                await _genreService.CreateAsync(genre);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(GenreDTO genre)
        {
            try
            {
                await _genreService.UpdateAsync(genre);
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
                await _genreService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
