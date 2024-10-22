using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAcademy.Class.Evaluators
{
    public class FieldSpeedEvaluator
    {
        public bool Evaluate(Infielder infielder)
        {
            return infielder.FieldSpeed > 85;
        }
    }
}