using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballAcademy.Enum;
using BaseballAcademy.Interface;

namespace BaseballAcademy.Class
{
    /// <summary>
    /// 投手
    /// </summary>
    public class Pitcher : Player, IPitchable
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="name"></param>
        /// <param name="backNumber"></param>
        public Pitcher(string name, int backNumber) : base(name, backNumber, BaseballPosition.Pitcher)
        { }

        /// <summary>
        /// 投球球速
        /// </summary>
        public double Velocity { get; set; }

        /// <summary>
        /// 投球轉速
        /// </summary>
        public double Spinrate { get; set; }

        /// <summary>
        /// 投球
        /// </summary>
        public void Pitch()
        {
            Console.WriteLine($"{Name} pitches a ball.");
        }

        /// <summary>
        /// 自我介紹，補充自己是投手
        /// </summary>
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I'm a pitcher.");
        }
    }
}