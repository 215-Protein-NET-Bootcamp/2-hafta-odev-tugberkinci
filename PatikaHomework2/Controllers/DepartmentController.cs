using Microsoft.AspNetCore.Mvc;
using PatikaHomework2.Service.IServices;

namespace PatikaHomework2.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_departmentService.GetAll());
        }

    }
}
