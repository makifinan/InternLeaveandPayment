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
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetByEmailPassword(string email,string password)
        {
            var result = _employeeService.GetByEmailPassword(email,password);
            if (result.Result.Datas == null)
            {
                return NotFound(result.Result.Message);
            }
            return Ok(result.Result);
        }
    }
}
