using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAcademy.Class.Evaluators
{
    /// <summary>
    /// 守備速度評估單位
    /// </summary>
    public class FieldSpeedEvaluator : IEvaluator<Infielder>
    {
        public bool Evaluate(Infielder infielder)
        {
            return infielder.FieldSpeed > 85;
        }
    }
}