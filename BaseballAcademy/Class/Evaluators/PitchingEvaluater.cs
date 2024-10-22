using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAcademy.Class.Evaluators
{
    public class PitchingEvaluator
    {
        public bool Evaluate(Pitcher pitcher)
        {
            return pitcher.Velocity > 90 && pitcher.Spinrate > 1800;
        }
    }
}