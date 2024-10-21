using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAcademy.Class
{
    public class Player
    {
        public required string Name { get; set; }

        public int Position { get; set; }

        public int Power { get; set; }

        public int Speed { get; set; }
    }
}