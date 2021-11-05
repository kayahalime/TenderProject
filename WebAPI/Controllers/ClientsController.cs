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
    public class ClientsController : ControllerBase
    {
        IClientService _clientService;
        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;

        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _clientService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _clientService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Client client)
        {
            var result = _clientService.Add(client);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Client client)
        {
            var result = _clientService.Update(client);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}