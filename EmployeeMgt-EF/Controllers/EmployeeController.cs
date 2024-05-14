using EmployeeMgt_EF.ModelEntity;
using EmployeeMgt_EF.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMgt_EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        public readonly IEmployee iEmployee;
        public EmployeeController(IEmployee iemploy) {
        iEmployee= iemploy;
        }
        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            return Ok(iEmployee.GetAllEmployee());       
        }
        [HttpGet("GetById")]
        public IActionResult GetEmployeeById(int id)
        {
            return Ok(iEmployee.GetEmployeeById(id));
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            iEmployee.AddEmployee(employee);
            return Ok("added Successfully");
        }
        [HttpPut]
        public IActionResult UpdateEmployee(Employee employ)
        {
            iEmployee.UpdateEmployee(employ);
            return Ok("updated successfully");
        }
        [HttpDelete]
        public IActionResult DeleteEmployee(int id)
        {
            if (id != null)
            {
                iEmployee.DeleteEmployee(id);
            }
            else
            {
                return BadRequest("bad request");
            }
            return Ok("deletion successfully");

        }

    }
}
