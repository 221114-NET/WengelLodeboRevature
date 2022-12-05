using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class ReimbursementRequest
    {
        public int Id { get; set; }
        public string EmailAddress {get; set;}
        public string RequestType { get; set; }
        public decimal Amount { get; set; }

        public bool IsApproved {get; set;}
        public bool RequestStatus {get; set;}


        public ReimbursementRequest()
        {

        }

        public ReimbursementRequest(int id, string emailAddress , string requestType, decimal amount, DateTimeOffset createdDate, bool isApproved, bool status)
        {
            Id = id;
            EmailAddress = emailAddress;
            RequestType = requestType;
            Amount = amount;
            IsApproved = isApproved;
            RequestStatus = status;

        }

            
    }

    
}