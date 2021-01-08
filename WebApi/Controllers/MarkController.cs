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
    public class MarkController : ControllerBase
    {
        private IMarkService _markService;

        public MarkController(IMarkService service)
        {
            _markService = service;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                var marks = _markService.GetAll();
                return Ok(marks);
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
                var mark = _markService.Get(id);

                if (mark != null)
                {
                    return Ok(mark);
                }
                else return StatusCode(204);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(MarkDTO mark)
        {
            try
            {
                await _markService.CreateAsync(mark);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(MarkDTO mark)
        {
            try
            {
                await _markService.UpdateAsync(mark);
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
                await _markService.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
