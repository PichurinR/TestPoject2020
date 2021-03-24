using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using BAL.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProject2020.ApiControllers
{
    [Route("api/[controller]")]
    public class TicketController : Controller
    {
        private readonly ITicketService _service;

        public TicketController(ITicketService service)
        {
            _service = service;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]TicketVM model)
        {
            _service.CreateTicket(model);
        }

        // PUT api/<controller>
        [HttpPut]
        public void Put(TicketVM model)
        {
            _service.EditTicket(model);
        }

        [HttpPut("id")]
        public void Put(long id)
        {
            _service.Voting(id);
        }
    }
}
