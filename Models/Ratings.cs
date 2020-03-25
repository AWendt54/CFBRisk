using System;
using System.Collections.Generic;
using System.Text;

namespace CFBRisk.Models
{
    public class Ratings
    {
        public int Overall { get; set; }
        public int TotalTurns { get; set; }
        public int GameTurns { get; set; }
        public int MVPs { get; set; }
        public int Streak { get; set; }
        public int Awards { get; set; }
    }
}
