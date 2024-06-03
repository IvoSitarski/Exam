using Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class BalloonHelper
    {
        public int TotalBalloons { get; set; }
        public int HeliumBalloons { get; set; }
        public int RegularBalloons { get; set; }

        public BalloonHelper(int totalBalloons)
        {
            TotalBalloons = totalBalloons;
            CalculateBalloons();
        }

        private void CalculateBalloons()
        {
            HeliumBalloons = TotalBalloons / 2;
            RegularBalloons = TotalBalloons - HeliumBalloons;
        }
    }


}
