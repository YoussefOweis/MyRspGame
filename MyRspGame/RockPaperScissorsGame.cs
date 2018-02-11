using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRspGame
{
    class RockPaperScissorsGame
    {
        private Random rng;
        private int wins;
        private int losses;
        private int ties;

        public RockPaperScissorsGame()
        {
            rng = new Random();

        }
        public void Play()
        {

            string userChoice;
            userChoice = PromptUser();

            while (userChoice != "Q")
            {
                
                string computerChoice = getComputerChoice();
                DetermineWinner(userChoice, computerChoice);
                PrintScore();
                userChoice = PromptUser();
                
               
            }
        }

        private void PrintScore()
        {
            Console.WriteLine();
            Console.WriteLine("wins{0}",wins);
            Console.WriteLine("losses{0}",losses);
            Console.WriteLine("ties{0}",ties);
            Console.WriteLine();
            Console.WriteLine("Press enter to continue ...");
            Console.ReadLine();
            Console.Clear();




        }

        private void DetermineWinner(string userChoice, string computerChoice)
        {
            if (userChoice == computerChoice)
            {
                ties++;
                Console.WriteLine("you both picked {0}, you tied !",ConvertChoiceToWord(userChoice));
            }
            else if ((userChoice == "R"&& computerChoice == "S")||(userChoice== "P" && computerChoice=="R")||(userChoice=="S"&&computerChoice=="P"))
                {
                wins++;
                Console.WriteLine("you picked {0} and the computer picked {1} , you won  ",ConvertChoiceToWord(userChoice),ConvertChoiceToWord(computerChoice));             
                  
            }
            else {
                losses++;
                Console.WriteLine("you picked {0} and the computer picked {1} , you loss  ", ConvertChoiceToWord(userChoice), ConvertChoiceToWord(computerChoice));
            }
        }

        private string ConvertChoiceToWord(string choice)
        {
            if (choice == "R")
                return "Rock";
            else if (choice == "S")
                return "Scissors";
            else
                return "Paper";

            
        }
        private string getComputerChoice()
        {
            int choice = rng.Next(1, 4);
            if (choice == 1)
            {
                return "R";

            }
            else if (choice == 2)
            {
                return "P";

            }
            else
            {
                return "S";
            }
        }

        private string PromptUser()
        {
            while (true)
            {
                Console.Write("enter ur choice(R)ock, (P)aper, (S)cissors,(Q)uit");
                String Choice = Console.ReadLine();
                if (Choice == "R" || Choice == "P" || Choice == "S" || Choice == "Q")
                {
                    return Choice;
                }
                else
                {
                    Console.WriteLine("that was not a valid Choice");
                }
            }
        }
    }
}
