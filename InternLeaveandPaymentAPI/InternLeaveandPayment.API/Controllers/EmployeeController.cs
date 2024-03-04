using InternLeaveandPayment.API.Controllers.Common;
using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Domain.DTOs.Employee;
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

        [HttpPost("~/api/GetByEmailPasswordEmployee")]
        public IActionResult GetByEmailPassword(EmployeeLoginDTO employeeLoginDTO)
        {
            var result = _employeeService.GetByEmailPassword(employeeLoginDTO.Email, employeeLoginDTO.Password);
            if (result.Result.Datas == null)
            {
                return NotFound(result.Result.Message);
            }
            return Ok(result.Result);
        }

        [HttpPost("~/api/GetByIDEmployee/{id}")]
        public IActionResult GetByIDEmployee(int id)
        {
            var result = _employeeService.GetByIDEmployee(id);
            if (result.Result.Datas == null)
            {
                return NotFound(result.Result.Message);
            }
            return Ok(result.Result);
        }
    }
}
