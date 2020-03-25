using System;
using System.Collections.Generic;
using System.Text;

namespace CFBRisk.Models
{
    public class Turn
    {
        public int Id { get; set; }
        public int Season { get; set; }
        public int Day { get; set; }
        public bool Complete { get; set; }
        public bool Active { get; set; }
    }
}
