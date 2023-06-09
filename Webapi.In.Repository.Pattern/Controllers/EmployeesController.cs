using Microsoft.AspNetCore.Mvc;
using Webapi.In.Repository.Pattern.Infrastructure;
using Webapi.In.Repository.Pattern.Models;
using Webapi.In.Repository.Pattern.Models.Data.EmployeeDBContext;
using Webapi.In.Repository.Pattern.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Webapi.In.Repository.Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployee _Iemployee;  
        public EmployeesController(IEmployee iemployee)
        {
            _Iemployee = iemployee;
        }

        // POST api/<EmployeesController>
        [HttpPost("AddEmployee")]
        public ActionResult AddEmployee([FromBody] AddEmployeeModel model)
        {
            bool result = _Iemployee.AddEmployee(model);
            if (result)
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            return BadRequest();
        }

        // GET: api/<EmployeesController>
        [HttpGet("GetEmployees")]
        public ActionResult GetEmployees() 
        {
            var model = _Iemployee.GetEmployees();
            if(model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // GET api/<EmployeesController>/5
        [HttpGet("GetEmployee/{id}")]
        public ActionResult GetEmployee(int id)
        {
            var model = _Iemployee.GetEmployee(id);
            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

       

        // PUT api/<EmployeesController>/5
        [HttpPut("UpdateEmployee/{id}")]
        public ActionResult UpdateEmployee([FromBody] Employee model)
        {
            bool result = _Iemployee.UpdateEmployee(model);
            if (result)
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            return BadRequest();
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("DeleteEmployee/{id}")]
        public ActionResult DeleteEmployee(int id)
        {
            bool result = _Iemployee.DeleteEmployee(id);
            if (result)
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            return BadRequest();
        }
    }
}
