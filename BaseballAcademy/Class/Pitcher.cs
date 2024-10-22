using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballAcademy.Enum;

namespace BaseballAcademy.Class
{
    public class Pitcher : Player
    {
        public Pitcher(string name, int backNumber) : base(name, backNumber, BaseballPosition.Pitcher)
        { }

        public double Velocity { get; set; }
        public double Spinrate { get; set; }

        public void Pitch()
        {
            Console.WriteLine($"{Name} pitches a ball.");
        }
    }
}