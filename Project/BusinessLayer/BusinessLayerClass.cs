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
        Employee PostEmployee(Employee e);
    }

    public class BusinessLayerClass : IBusinessLayerClass
    {
        private readonly IRepositoryClass _repo;


        
        public BusinessLayerClass(IRepositoryClass repo)
        {
            _repo = repo;
        }
        public Employee PostEmployee(Employee e)
        {
            // e.Name = "John";
            // Employee emp = _repo.PostEmployee(e);
            // Console.WriteLine("josh");
            // return emp;
        }
    }
}