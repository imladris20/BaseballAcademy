using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseballAcademy.Class;
using BaseballAcademy.Class.Evaluators;

namespace BaseballAcademy.Evaluators
{
    /// <summary>
    /// 職業球員認證機構
    /// </summary>
    public class CertificationAgency
    {
        /// <summary>
        /// 認證守備速度的單位
        /// </summary>
        private FieldSpeedEvaluator fieldSpeedEvaluator = new FieldSpeedEvaluator();

        /// <summary>
        /// 認證投球能力的單位
        /// </summary>
        private PitchingEvaluator pitchingEvaluator = new PitchingEvaluator();

        /// <summary>
        /// 審核能力
        /// </summary>
        /// <param name="player">球員</param>
        /// <returns></returns>
        public bool Certify(Player player)
        {
            Console.WriteLine($"Certificating {player.Name}......");

            if (player is Infielder infielder)
            {
                if (!fieldSpeedEvaluator.Evaluate(infielder))
                {
                    Console.WriteLine($"{infielder.Name} did not pass the field speed evaluation.");
                    Console.WriteLine($"{player.Name} needs more training.");
                    return false;
                }
            }
            else if (player is Pitcher pitcher)
            {
                if (!pitchingEvaluator.Evaluate(pitcher))
                {
                    Console.WriteLine($"{pitcher.Name} did not pass the pitching evaluation.");
                    Console.WriteLine($"{player.Name} needs more training.");
                    return false;
                }
            }
            Console.WriteLine($"{player.Name} is certified as a professional player!");
            return true;
        }
    }
}