
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
    public class Employees : ControllerBase
    {
        private BusinessLayerEmp _busLayer = new BusinessLayerEmp();
        [HttpPost]
        public Employee PostEmployee(Employee e)
        {
            e.Type = "MANAGER";
            Employee emp =_busLayer.PostEmployee(e);
            //Employee emp = BusinessLayer.PostEmployee(e);
            return emp;

        }
    }
}