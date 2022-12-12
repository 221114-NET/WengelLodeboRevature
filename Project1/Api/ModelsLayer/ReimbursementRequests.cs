using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class ReimbursementRequests
    {
        public ReimbursementRequests(int id, string expenseType, decimal amount, bool isApproved, string requestStatus,int registerId)
        {
            RequestId = id;
            ExpenseType = expenseType;
            Amount = amount;
            IsApproved = isApproved;
            RequestStatus = requestStatus;
            RegisterId = registerId;
        }

        public ReimbursementRequests()
        {

        }

        public int RequestId { get; set; }
        public string ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public bool IsApproved { get; set; }
        public string RequestStatus { get; set; }
        public int RegisterId { get; set; }
        
    
    }
}