using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAcademy.Class.Evaluators
{
    /// <summary>
    /// 投球能力評估單位
    /// </summary>
    public class PitchingEvaluator : IEvaluator<Pitcher>
    {
        public bool Evaluate(Pitcher pitcher)
        {
            return pitcher.Velocity > 90 && pitcher.Spinrate > 1800;
        }
    }
}