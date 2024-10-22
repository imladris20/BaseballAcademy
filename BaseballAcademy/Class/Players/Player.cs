using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballAcademy.Enum;

namespace BaseballAcademy.Class
{
    /// <summary>
    /// 球員
    /// </summary>
    public abstract class Player
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="backNumber">背號</param>
        /// <param name="position">守備位置</param>
        public Player(string name, int backNumber, BaseballPosition position)
        {
            Name = name;
            BackNumber = backNumber;
            Position = position;
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string? Name;

        /// <summary>
        /// 背號
        /// </summary>
        public int BackNumber;

        /// <summary>
        /// 守備位置
        /// </summary>
        public BaseballPosition Position { get; private set; }

        /// <summary>
        /// 更新守位
        /// </summary>
        /// <param name="newPosition">新的守備位置</param>
        public void ChangePosition(BaseballPosition newPosition)
        {
            Position = newPosition;
        }

        /// <summary>
        /// 自我介紹，講姓名跟背號
        /// </summary>
        public virtual void Introduce()
        {
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My back number is {BackNumber}.");
        }


    }
}