using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDDiceRoller.Workers
{
    class MultiRollInputer
    {
        private static readonly Constants _constants = new Constants();

        internal string[] DiceRollInput()
        {
            string diceToRoll = Console.ReadLine();
            String[] rolls = diceToRoll.Split(_constants.inputSeparator);

            return rolls;
        }

        internal int[] DiceRollCoverter(string[] rollsInput)
        {
            int inputLength = rollsInput.Count();

            int[] convertedInput = new int[inputLength];

            for (int i = 0; i < (inputLength); i++)
            {
                convertedInput[i] = Convert.ToInt32(rollsInput[i]);
            }

            return convertedInput;
        }
}
}
