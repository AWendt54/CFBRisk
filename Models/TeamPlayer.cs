using System;
using System.Collections.Generic;
using System.Text;

namespace CFBRisk.Models
{
    public class TeamPlayer
    {
        public string Team { get; set; }
        public string Player { get; set; }
        public int TurnsPlayed { get; set; }
        public int MVPs { get; set; }
        public LastTurn LastTurn { get; set; }
    }
}
