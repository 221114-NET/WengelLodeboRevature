using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class ReimbursmentRequest
    {
        public int ID { get; set; }
        public string EmailAddress { get; set; }
        public string RequestType { get; set; }
        public decimal Amount { get; set; }
        public bool IsApproved { get; set; }
        public bool RequestStatus { get; set; }


        public ReimbursmentRequest()
        {
            
        }
        public ReimbursmentRequest(int id, string email, string requestType, decimal amount, bool isApproved, bool requestStatus)
        {
            ID = id;
            EmailAddress = email;
            RequestType = requestType;
            Amount = amount;
            IsApproved = isApproved;
            RequestStatus = requestStatus;

        }

    }
}