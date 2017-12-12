using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDDiceRoller
{
    public class Constants
    {
        public string startProgPrompt = "How many dice do you need to roll?" +
                "\n1 - One" +
                "\n2 - Multiple" +
                "\n3 - Quit";

        public string numericFirstCheck = "1";
        public string alphaFirstCheck = "one";
        public string singleDicePrompt = "Which die do you need to roll?" +
                    "\nPress enter to roll again or type quit to return to beginning.";
        public string invalidSingleNonInt = "Non-Number Detected. Try Again.";

        public string numericSecondCheck = "2";
        public string alphaSecondCheck = "multiple";
        public string multipleDicePrompt = "Which dice do you need to roll?" +
                        "\nInput Format for each dice: (# of dice),(which die)." +
                        "\nComma separate each dice set.";
        public string invalidMultiInputLength = "Invalid input length. Try again.";
        public string invalidMultiNonIntInput = "Non-Number Detected. Try Again.";
        public char inputSeparator = ',';
        public string totalRollValue = "Total of rolls: {0}";

        public string numericQuitCheck = "3";
        public string alphaQuitCheck = "quit";
        
    }
}
