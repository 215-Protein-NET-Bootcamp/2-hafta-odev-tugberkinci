using Microsoft.AspNetCore.Mvc;
using PatikaHomework2.Service.IServices;

namespace PatikaHomework2.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeService;

        public EmployeeController(IEmployeeService employeService)
        {
            _employeService = employeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employeeList = await  Task.Run(()=>_employeService.GetAll());
            return Ok(employeeList);

        }

    }
}
