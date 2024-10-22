using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballAcademy.Class;
using BaseballAcademy.Class.Evaluators;

namespace BaseballAcademy.Evaluators
{
    public class CertificationAgency
    {
        private FieldSpeedEvaluator fieldSpeedEvaluator = new FieldSpeedEvaluator();
        private PitchingEvaluator pitchingEvaluator = new PitchingEvaluator();

        public bool Certify(Player player)
        {
            Console.WriteLine($"Certificating {player.Name}......");

            if (player is Infielder infielder)
            {
                // 對內野手使用 FieldSpeedEvaluator
                if (!fieldSpeedEvaluator.Evaluate(infielder))
                {
                    Console.WriteLine($"{infielder.Name} did not pass the field speed evaluation.");
                    Console.WriteLine($"{player.Name} needs more training.");
                    return false;
                }
            }
            else if (player is Pitcher pitcher)
            {
                // 對投手使用 PitchingEvaluator
                if (!pitchingEvaluator.Evaluate(pitcher))
                {
                    Console.WriteLine($"{pitcher.Name} did not pass the pitching evaluation.");
                    Console.WriteLine($"{player.Name} needs more training.");
                    return false;
                }
            }
            Console.WriteLine($"{player.Name} is certified as a professional player!");
            return true; // 所有評估都通過
        }
    }
}