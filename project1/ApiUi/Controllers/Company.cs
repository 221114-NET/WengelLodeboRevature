using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using BusinessLayer;

namespace ApiUi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class Company : ControllerBase
    {
        private readonly IBusinessLayerClass _ibus;

        public Company(IBusinessLayerClass ibus)
        {
            this._ibus = ibus;
        }


        [HttpPost("AccountRegistration")]
        public ActionResult<Register> PostRegister(Register r)
        {
            if(ModelState.IsValid){
                Register r1 = this._ibus.PostRegister(r);
            }else
            {
            return NotFound("that modelbinding didn't work");
            }
            return Created($"https://localhost:5030/api/Company/getregister/{r.RegisterId}",r);
            
        }

        // [HttpPost("CreateNewImbursement")]
        // public ActionResult<ReimbursementRequest> PostExpences(e)
        // {

        // }
    }
}