using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballAcademy.Enum;

namespace BaseballAcademy.Class
{

    public class Infielder : Player
    {

        private static readonly HashSet<BaseballPosition> infielderPositions = new HashSet<BaseballPosition>
        {
            BaseballPosition.FirstBase,
            BaseballPosition.SecondBase,
            BaseballPosition.ThirdBase,
            BaseballPosition.Shortstop
        };

        public Infielder(string name, int backNumber, BaseballPosition position) : base(name, backNumber, position)
        {
            if (!infielderPositions.Contains(position))
            {
                throw new ArgumentException("Position must be an infielder position.");
            }
        }

        public double FieldSpeed { get; set; }

        public void Field()
        {
            Console.WriteLine($"{Name} fields a ball.");
        }
    }
}