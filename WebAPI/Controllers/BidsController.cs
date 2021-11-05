using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidsController : ControllerBase
    {
        IBidService _bidService;
        public BidsController(IBidService bidService)
        {
            _bidService = bidService;

        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bidService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _bidService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Bid bid)
        {
            var result = _bidService.Add(bid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Bid bid)
        {
            var result = _bidService.Update(bid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}