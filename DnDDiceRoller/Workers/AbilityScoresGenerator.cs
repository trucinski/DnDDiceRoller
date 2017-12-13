using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDDiceRoller.Workers
{   

    class AbilityScoresGenerator
    {
        public static readonly Random _random = new Random();

        internal void GenerateAbilityScores()
        {
            string[] abilityScoresArray = new string[6];
            int[] scoresToCheck = new int[4];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    scoresToCheck[j] = _random.Next(1, 7);
                }

                Array.Sort(scoresToCheck);
                Array.Reverse(scoresToCheck);

                abilityScoresArray[i] = Convert.ToString((scoresToCheck[0] + scoresToCheck[1] + scoresToCheck[2]));

            }

            string abilityScores = string.Empty;

            for (int i = 0; i < abilityScoresArray.Count(); i++)
            {
                abilityScores = abilityScores + abilityScoresArray[i] + ",";
            }

            Console.WriteLine(abilityScores);
            
        }

    }
}
