﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }
        public int GuestAge { get; set; }
        public string GuestName { get; set; }
    }
}
