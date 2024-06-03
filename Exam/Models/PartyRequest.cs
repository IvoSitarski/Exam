using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{

    public class PartyRequest
    {
        [Key]
        public int RequestId { get; set; }
        public string Applicant { get; set; }
        public string ApplicantPN { get; set; }
        public string BirthdayPerson { get; set; }
        public int BirthdayPersonAge { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime PartyDate { get; set; }
        public int Baloons { get; set; } // Общ брой балони
        public int RegularBalloons { get; set; } // Брой обикновени балони
        public int HeliumBalloons { get; set; } // Брой балони с хелий
        public List<Guest> Guests { get; set; } = new List<Guest>();
    }

}
