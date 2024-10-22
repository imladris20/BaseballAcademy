using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballAcademy.Enum;
using BaseballAcademy.Interface;

namespace BaseballAcademy.Class
{
    public class Pitcher : Player, IPitchable
    {
        public Pitcher(string name, int backNumber) : base(name, backNumber, BaseballPosition.Pitcher)
        { }

        public double Velocity { get; set; }
        public double Spinrate { get; set; }

        public void Pitch()
        {
            Console.WriteLine($"{Name} pitches a ball.");
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I'm a pitcher.");
        }
    }
}