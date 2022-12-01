using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;

namespace BusinessLayer
{
    public class BusinessLayerEmp
    {
        private readonly RepoEmpClass _repo = new RepoEmpClass();
        public Employee PostEmployee(Employee e)
        {
            e.Name = "John";
            Employee emp =_repo.PostEmployee(e);
            return emp;
        }
    }
}