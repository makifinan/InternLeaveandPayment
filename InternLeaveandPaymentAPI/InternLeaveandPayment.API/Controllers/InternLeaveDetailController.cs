using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Domain.DTOs.InternLeaveDetail;
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
    public class InternLeaveDetailController : ControllerBase
    {
        private readonly IInternLeaveDetailService _internLeaveDetailService;

        public InternLeaveDetailController(IInternLeaveDetailService internLeaveDetailService)
        {
            _internLeaveDetailService = internLeaveDetailService;
        }

        [HttpPost]
        public async Task<IActionResult> AddInternLeaveDetailAsync(InternLeaveDetailAddDTO internLeaveDetailAddDTO)
        {
            var result =await _internLeaveDetailService.InternLeaveDetailAddAsync(internLeaveDetailAddDTO);
            if (result.Datas==null)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
    }
}
