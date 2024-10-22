using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballAcademy.Enum;

namespace BaseballAcademy.Class
{
    public abstract class Player
    {
        public Player(string name, int backNumber, BaseballPosition position)
        {
            Name = name;
            _position = position;
            _backNumber = backNumber;
        }

        public string? Name { get; set; }

        public BaseballPosition Position
        {
            get { return _position; }
        }

        public int BackNumber
        {
            get { return _backNumber; }
        }

        private int _backNumber;

        private BaseballPosition _position;

        public virtual void Introduce()
        {
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My back number is {BackNumber}.");
        }

        public void ChangePosition(BaseballPosition newPosition)
        {
            _position = newPosition;
        }
    }
}