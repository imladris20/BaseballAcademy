using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAcademy.Class
{
    public class Player
    {
        public Player(string name, int backNumber, int position, int power, int speed)
        {
            Name = name;
            Position = position;
            Power = power;
            Speed = speed;
            _backNumber = backNumber;
        }

        public string? Name { get; set; }

        public int Position { get; set; }

        public int Power { get; set; }

        public int Speed { get; set; }

        public int BackNumber
        {
            get { return _backNumber; }
        }

        private readonly int _backNumber;

        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My back number is {BackNumber}.");
            Console.WriteLine($"I play as {Position}.");
            Console.WriteLine($"My power is {Power} and my speed is {Speed}.");
        }
    }
}