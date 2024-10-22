using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAcademy.Class.Evaluators
{
    /// <summary>
    /// 守備單位要有評估動作
    /// </summary>
    public interface IEvaluator<T> where T : Player
    {
        bool Evaluate(T player);
    }
}