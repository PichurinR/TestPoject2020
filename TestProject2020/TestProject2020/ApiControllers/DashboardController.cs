using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Interface;
using BAL.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestProject2020.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _service;

        public DashboardController(IDashboardService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<DashboardVM> Get()
        {
            return _service.GetDashboards();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public DashboardVM Get(long id)
        {
            return _service.GetDashboard(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] DashboardVM value)
        {
            _service.CreateDashboard(value);
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _service.DeleteDashboard(id);
        }
    }
}
