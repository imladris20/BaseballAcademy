using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAcademy.Class
{
    public class Player
    {
        public Player(string name, int position, int power, int speed)
        {
            Name = name;
            Position = position;
            Power = power;
            Speed = speed;
        }

        public string? Name { get; set; }

        public int Position { get; set; }

        public int Power { get; set; }

        public int Speed { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"I play as {Position}.");
            Console.WriteLine($"My power is {Power} and my speed is {Speed}.");
        }
    }
}