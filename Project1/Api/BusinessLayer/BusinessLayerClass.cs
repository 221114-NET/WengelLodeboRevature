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
        Register GetEmployee(string email, string password);
        List<Register> GetEmployeeList();
        List<ReimbursementRequests> GetExpenseList(int registerId);
        List<ReimbursementRequests> GetExpensesList();
        Register PostAccount(Register r);
        ReimbursementRequests PostExpenses(ReimbursementRequests r);

    }

    public class BusinessLayerClass : IBusinessLayerClass
    {
        private readonly IRepoLayerClass _repo;

        public BusinessLayerClass(IRepoLayerClass repo)
        {
            _repo = repo;
        }

        public Register GetEmployee(string email, string password)
        {
            Register r1 = this._repo.GetEmployee(email, password);
            return r1;
        }

        public List<Register> GetEmployeeList()
        {
            List<Register> l = this._repo.GetEmployeeList();
            return l;
        }

        public List<ReimbursementRequests> GetExpenseList(int registerId)
        {
             List<ReimbursementRequests> l = this._repo.GetExpenseList(registerId);
            return l;
        }

        public List<ReimbursementRequests> GetExpensesList()
        {

            List<ReimbursementRequests> l = this._repo.GetExpensesList();
            return l;
        }

        public Register PostAccount(Register r)
        {
            Register r1 = this._repo.PostAccount(r);
            return r1;
        }

        public ReimbursementRequests PostExpenses(ReimbursementRequests r)
        {
            ReimbursementRequests r1 = this._repo.PostExpenses(r);
            return r1;
        }


    }
}