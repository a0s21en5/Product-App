using Employee_Web_Application.Models;
using Employee_Web_Application.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Web_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        //Get All Employees
        [Route("Get")]
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            List<Employees> AllEmployees = await _employeesService.GetAllEmployees();
            return Ok(AllEmployees);
        }

        //AddEmployees
        [Route("Insert")]
        [HttpPost]
        public async Task<IActionResult> InsertEmployees(Employees employees)
        {
            bool insertEmployeesStatus = await _employeesService.InsertEmployees(employees);
            return Ok(insertEmployeesStatus);
        }
    }
}
