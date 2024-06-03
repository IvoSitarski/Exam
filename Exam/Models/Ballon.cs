using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Balloon
    {
        [Key]
        public int Id { get; set; }
        public int NormalBalloons { get; set; }
        public int HeliumBalloons { get; set; }
    }
}
