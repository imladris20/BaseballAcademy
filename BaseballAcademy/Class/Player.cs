using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballAcademy.Enum;

namespace BaseballAcademy.Class
{
    public class Player
    {
        public Player(string name, int backNumber, BaseballPosition position, int power, int speed)
        {
            Name = name;
            _position = position;
            Power = power;
            Speed = speed;
            _backNumber = backNumber;
        }

        public string? Name { get; set; }

        public BaseballPosition Position
        {
            get { return _position; }
        }

        public int Power { get; set; }

        public int Speed { get; set; }

        public int BackNumber
        {
            get { return _backNumber; }
        }

        private int _backNumber;

        private BaseballPosition _position;

        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My back number is {BackNumber}.");
            Console.WriteLine($"I play as {Position}.");
            Console.WriteLine($"My power is {Power} and my speed is {Speed}.");
        }

        public void ChangePosition(BaseballPosition newPosition)
        {
            _position = newPosition;
        }
    }
}