using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class ApprovedRequest
    {
        [Key]
        public int ApprovedRequestId { get; set; }
        public string Applicant { get; set; }
        public string ApplicantPN { get; set; }
        public string BirthdayPerson { get; set; }
        public int BirthdayPersonAge { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime PartyDate { get; set; }
        public int Baloons { get; set; }
        public int RegularBalloons { get; set; }
        public int HeliumBalloons { get; set; }
        public List<Guest> Guests { get; set; } = new List<Guest>();
    }
}
