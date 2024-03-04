using InternLeaveandPayment.API.Controllers.Common;
using InternLeaveandPayment.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternLeaveandPayment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeparmentController : BaseController
    {
        private readonly IDepartmentService _departmentService;

        public DeparmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpPost("~/api/GetAllDepartment/{id}")]
        public IActionResult GetAllDepartment(int id)
        {
            var result = _departmentService.GetAllDepartment(id);
            if (result==null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}
