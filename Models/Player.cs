using System;
using System.Collections.Generic;
using System.Text;

namespace CFBRisk.Models
{
    public class Player
    {
        public string Name { get; set; }
        public Team Team { get; set; }
        public Ratings Ratings { get; set; }
        public Stats Stats { get; set; }
        public List<Turn> Turns { get; set; }
    }
}
