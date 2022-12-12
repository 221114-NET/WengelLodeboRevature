using ModelsLayer;
using RepoLayer;

namespace tests.api
{
    public class MockRepoLayer : IRepoLayerClass
    {
        public List<Register> GetEmployeeList()
        {
           Register r2 = new Register(20, "Geli", "lali", "staff", "geli@company.com", "qwer","qwer");
           Register r3 = new Register(21, "lila", "lai", "staff", "lila@company.com", "rtyu","rtyu");
           List<Register> list = new List<Register>(){r2,r3};
           return list;
        }
        public List<ReimbursementRequests> GetExpensesList()
        {
            ReimbursementRequests r4 = new ReimbursementRequests(30, "Taxi", 456, true, "Pending", 33);
            List<ReimbursementRequests> list = new List<ReimbursementRequests>(){r4};
            return list;
        }
        public Register PostAccount(Register e)
        {
             throw new NotImplementedException();
        }
        public ReimbursementRequests PostExpenses(ReimbursementRequests r)
        {
             throw new NotImplementedException();
        }
        
        public  List<ReimbursementRequests> GetExpenseList(int registerId)
        {
            throw new NotImplementedException();
        }
        public Register GetEmployee(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}