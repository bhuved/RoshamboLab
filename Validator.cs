using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public static class Validator
    {
        public static string ValidateOtherPlayer()
        {
            string input;
            while (true)
            {
                Console.WriteLine("Would you like to play against The Jets or The Sharks (j/s)?: ");
                input = Console.ReadLine().ToLower().Trim();
                if (input == "j" || input == "s")

                    return input;
                Console.WriteLine("Invalid input. Please enter 'j' for Jets or 's' for Sharks.");

            }
        }
        public static string ValidateHumanRoshambo()
        {
            string input;
            while (true)
            {
                Console.Write("Rock, paper, or scissors? (R/P/S): ");
                input = Console.ReadLine()?.ToLower().Trim();

                if (input == "r" || input == "p" || input == "s")
                    return input;

                Console.WriteLine("Invalid input. Please enter 'R', 'P', or 'S'.");
            }
        }
        public static bool GetPlayAgainAnswer(string strMessage = "Would you like to Continue? y/n")
        {
            Console.WriteLine(strMessage);
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower().Trim() != "y")
            {
                return false;
            }
            return true;
        }
    }
}


