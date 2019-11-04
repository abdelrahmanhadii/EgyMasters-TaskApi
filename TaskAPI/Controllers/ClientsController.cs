using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.ServiceContracts;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientsController(IClientService clientService)
        {
            this._clientService = clientService;
        }
        // GET: api/Clients
        [HttpGet]
        public IEnumerable<ListClientDTO> Get()
        {
            return _clientService.GetAll();
        }

        // GET: api/Clients/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    //return _clientService.Ge();
        //}

        // POST: api/Clients
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateClientDTO value)
        {
            if (ModelState.IsValid)
                return Ok(await _clientService.Create(value));
            else
                return BadRequest("Model Not Valid!");
        }

        // PUT: api/Clients/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] UpdateClientDTO value)
        {
            if (ModelState.IsValid)
                return Ok(await _clientService.Update(value));
            else
                return BadRequest("Model Not Valid!");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _clientService.SoftDelete(id));
        }
    }
}
