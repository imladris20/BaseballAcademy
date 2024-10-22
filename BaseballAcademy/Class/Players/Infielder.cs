using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballAcademy.Enum;
using BaseballAcademy.Interface;

namespace BaseballAcademy.Class
{

    /// <summary>
    /// 內野手
    /// </summary>
    public class Infielder : Player, IFieldable
    {

        /// <summary>
        /// 內野手位置的集合
        /// </summary>
        private static readonly HashSet<BaseballPosition> infielderPositions = new HashSet<BaseballPosition>
        {
            BaseballPosition.FirstBase,
            BaseballPosition.SecondBase,
            BaseballPosition.ThirdBase,
            BaseballPosition.Shortstop
        };

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="name"></param>
        /// <param name="backNumber"></param>
        /// <param name="position"></param>
        /// <exception cref="ArgumentException"></exception>
        public Infielder(string name, int backNumber, BaseballPosition position) : base(name, backNumber, position)
        {
            if (!infielderPositions.Contains(position))
            {
                throw new ArgumentException("Position must be an infielder position.");
            }
        }

        /// <summary>
        /// 守備移動速度
        /// </summary>
        public double FieldSpeed { get; set; }

        /// <summary>
        /// 守備
        /// </summary>
        public void Field()
        {
            Console.WriteLine($"{Name} fields a ball.");
        }

        /// <summary>
        /// 自我介紹，補充自己是內野手
        /// </summary>
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine($"I'm an infielder.");
        }
    }
}