
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer;
using BusinessLayer;

namespace API.Project1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Company : ControllerBase
    {
        private readonly IBusinessLayerClass _ibus;
        public Company(IBusinessLayerClass ibus)
        {
            _ibus = ibus;
        }
        [HttpPost]
        public Employee PostEmployee(Employee e)
        {
            // e.Type = "MANAGER";
            Employee emp = _ibus.PostEmployee(e);
            Console.WriteLine(emp);
            //Employee emp = BusinessLayer.PostEmployee(e);
            return emp;

        }

        [HttpPost]
        public string PostReimbursementRequest(string Email, string RequestType, decimal Amount)
        {
            var reimbursmentRequest = _ibus.PostReimbursementRequest(Email, RequestType, Amount);
            return reimbursmentRequest;
        }



    }
}