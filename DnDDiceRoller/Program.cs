using DnDDiceRoller.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDDiceRoller
{
    class Program
    {
        public static readonly Random _random = new Random();
        public static readonly Constants _constants = new Constants();
        public static readonly MultiRollInputer _multiRollInputer = new MultiRollInputer();

        static void Main(string[] args)
        {
            bool runAgain = true;
            do
            {            
                Console.WriteLine(_constants.startProgPrompt);
                string choice = Console.ReadLine().ToLower();

                if (choice.Equals(_constants.numericFirstCheck) || choice.Equals(_constants.alphaFirstCheck))
                {
                   Console.WriteLine(_constants.singleDicePrompt);
                    int dieChoice = Convert.ToInt32(Console.ReadLine());
                       bool rollAgain = true;
    
                       do
                       {                  
                            int randValue = _random.Next(1, (dieChoice + 1));
                            Console.WriteLine(randValue);

                            if (!Console.ReadLine().Equals(string.Empty))
                            {
                                rollAgain = false;
                            }

                       } while (rollAgain);


                }

                if (choice.Equals(_constants.numericSecondCheck) || choice.Equals(_constants.alphaSecondCheck))
                {
                    int totalRoll = 0;
                    Console.WriteLine(_constants.multipleDicePrompt);

                    String[] rolls = _multiRollInputer.DiceRollInput();

                    bool validMultiLength = false;

                    do
                    {
                        if ((rolls.Count() % 2 == 0))
                        {
                            for (int i = 0; i < rolls.Count(); i++)
                            {
                                bool parsed = Int32.TryParse(rolls[i], out int inputParse);
                                if (!parsed)
                                {
                                    validMultiLength = false;
                                    Console.WriteLine(_constants.invalidMultiNonIntInput);
                                    rolls = _multiRollInputer.DiceRollInput();
                                    break;                                  
                                }

                                if(parsed)
                                {
                                    validMultiLength = true;
                                }
                                
                            }
                            
                        }

                        if (!((rolls.Count() % 2) == 0))
                        {
                            Console.WriteLine(_constants.invalidMultiInputLength);
                            rolls = _multiRollInputer.DiceRollInput();
                        }

                    } while (!validMultiLength);

                    int[] convertedRolls = _multiRollInputer.DiceRollCoverter(rolls);

                    for (int i = 0; i < convertedRolls.Count(); i+=2)
                    {
                        for (int j = 0; j < convertedRolls[i]; j++)
                        {
                            int randValue = _random.Next(1, (convertedRolls[i + 1]) + 1);
                            Console.WriteLine(randValue);
                            totalRoll = totalRoll + randValue;
                        }
                    }

                    Console.WriteLine(_constants.totalRollValue, totalRoll);
                }

            if (choice.Equals(_constants.numericQuitCheck) || choice.Equals(_constants.alphaQuitCheck))
            {
                runAgain = false;
            }

            } while (runAgain);
        }
    }
}
