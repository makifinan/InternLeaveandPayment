using InternLeaveandPayment.API.Controllers.Common;
using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.Domain.DTOs.Intern;
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
    public class InternController : BaseController
    {
        private readonly IInternService _internService;

        public InternController(IInternService internService)
        {
            _internService = internService;
        }

        [HttpGet("~/api/GetAllIntern")]
        public IActionResult GetAllIntern()
        {
            var result = _internService.GetAllIntern();
            if (result.Result.Datas==null)
            {
                return NotFound();
            }
            return Ok(result.Result);
        }


        [HttpPost("~/api/GetByEmailPassword")]
        public IActionResult GetByEmailPassword(InternLoginDTO internLoginDTO)
        {
            var result = _internService.GetByEmailPassword(internLoginDTO.Email, internLoginDTO.Password);
            if (result.Result.Datas == null)
            {
                return NotFound(result.Result.Message);
            }
            return Ok(result.Result);
        }



        [HttpPost("~/api/AddIntern")]
        public IActionResult AddIntern(InternAddDTO internAddDTO)
        {
            var result = _internService.AddIntern(internAddDTO);
            if (result.Result.Datas==null)
            {
                return BadRequest(result.Result.Message);
            }
            return Ok(result.Result);
        }

        
    }
}
