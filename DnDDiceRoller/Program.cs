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

        static void Main(string[] args)
        {
            bool runAgain = true;
            do
            {

            
            Console.WriteLine("How many dice do you need to roll?" +
                "\n1 - One" +
                "\n2 - Multiple" +
                "\n3 - Quit");
            string choice = Console.ReadLine().ToLower();

            if (choice.Equals("1") || choice.Equals("one"))
            {
                Console.WriteLine("Which die do you need to roll?" +
                    "\nPress enter to roll again or type quit to return to beginning.");
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
                if (choice.Equals("2") || choice.Equals("multiple"))
                {
                    int totalRoll = 0;
                    Console.WriteLine("Which dice do you need to roll?" +
                        "\nInput Format for each dice: (# of dice),(which die).");
                    string diceToRoll = Console.ReadLine();
                    String[] rolls = diceToRoll.Split(',');


                    for (int i = 0; i < rolls.Count(); i+=2)
                    {
                        int dieRolls = Convert.ToInt32(rolls[i]);
                        int dieToRoll = Convert.ToInt32(rolls[i + 1]);

                        

                        for (int j = 0; j < dieRolls; j++)
                        {
                            
                            int randValue = _random.Next(1, dieToRoll + 1);
                            Console.WriteLine(randValue);
                            totalRoll = totalRoll + randValue;
                        }
                            
                    }
                    Console.WriteLine(totalRoll);
                }

            if (choice.Equals("3") || choice.Equals("quit"))
            {
                runAgain = false;
            }

            } while (runAgain);
        }
    }
}
