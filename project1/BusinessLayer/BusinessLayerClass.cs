using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelsLayer;
using RepoLayer;

namespace BusinessLayer
{
    public interface IBusinessLayerClass
    {
        Register PostRegister(Register r);
    }

    public class BusinessLayerClass : IBusinessLayerClass
    {
        private readonly IRepoLayerClass _repo;

        public BusinessLayerClass(IRepoLayerClass repo)
        {
            _repo = repo;
        }

        public Register PostRegister(Register r)
        {
            // r.Name = "Abeni";
            // r.Role = "Manager";
            Register r1 = _repo.PostRegister(r);
            return r1;
        }
    }
}