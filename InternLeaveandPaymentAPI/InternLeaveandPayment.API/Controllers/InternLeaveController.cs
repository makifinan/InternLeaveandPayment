using InternLeaveandPayment.API.Controllers.Common;
using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Domain.DTOs.Common;
using InternLeaveandPayment.Domain.DTOs.InternLeave;
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
    public class InternLeaveController : BaseController
    {
        private readonly IInternLeaveService _internLeaveService;
        private readonly IInternLeaveDetailService _internLeaveDetailService;

        public InternLeaveController(IInternLeaveService internLeaveService,IInternLeaveDetailService internLeaveDetailService)
        {
            _internLeaveService = internLeaveService;
            _internLeaveDetailService = internLeaveDetailService;
        }

        [HttpPost("~/api/AddInternLeave")]
        public async Task<IActionResult> AddInternLeaveAsync(InternLeaveandDetailAddDTO internLeaveandDetailAddDTO)
        {
            var internLeaveID = await  _internLeaveService.AddInternLeaveAsync(internLeaveandDetailAddDTO.InternLeaveAddDTO);
            if (internLeaveID==0)
            {
                return BadRequest();
            }
            internLeaveandDetailAddDTO.InternLeaveDetailAddDTO.InternLeaveId = internLeaveID;
            var result = await _internLeaveDetailService.InternLeaveDetailAddAsync(internLeaveandDetailAddDTO.InternLeaveDetailAddDTO);
            if (result.Datas == null)
            {
                return BadRequest(result.Message);
            }
            return Ok();
        }

    }
}
