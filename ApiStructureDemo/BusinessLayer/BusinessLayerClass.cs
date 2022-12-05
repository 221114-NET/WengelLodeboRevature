using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;

namespace BusinessLayer
{
    public class BusinessLayerClass : IBusinessLayerClass
    {
        private readonly IRepositoryClass _repo;
        //private IEnumerable<object> requests;

        public BusinessLayerClass(IRepositoryClass repo)
        {
            _repo = repo;
        }

        public object CreateRequest()
        {
            throw new NotImplementedException();
        }

        public Employee PostEmployee(Employee e)
        {
           // e.Name = "John";
            Employee emp = _repo.PostEmployee(e);
           // Console.WriteLine("josh");
            return emp;
        }

        public string PostReimbursementRequest(string Email, string RequestType, decimal Amount)
        {
          return _repo.PostReimbursementRequest(Email, RequestType,Amount);
        }

       

          
       
            
    }
}