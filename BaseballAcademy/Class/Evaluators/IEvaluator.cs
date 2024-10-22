using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballAcademy.Class.Evaluators
{
    public interface IEvaluator
    {
        bool Evaluate(Player player);
    }
}