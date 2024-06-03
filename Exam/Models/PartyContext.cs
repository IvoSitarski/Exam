using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Exam.Models
{

    public class PartyContext
    {
        public List<PartyRequest> Requests { get; set; } = new List<PartyRequest>();
        public List<Guest> Guests { get; set; } = new List<Guest>();
        public List<ApprovedRequest> ApprovedRequests { get; set; } = new List<ApprovedRequest>();

        public void AddRequest(PartyRequest request)
        {
            request.RequestId = Requests.Count + 1;
            Requests.Add(request);
        }

        public void ApproveRequest(ApprovedRequest approvedRequest)
        {
            approvedRequest.ApprovedRequestId = ApprovedRequests.Count + 1;
            ApprovedRequests.Add(approvedRequest);
        }

        public void SaveChanges()
        {
            // В реално приложение тук ще има логика за записване в база данни.
        }
    }



}
