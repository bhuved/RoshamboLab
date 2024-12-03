using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class HumanPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            int i = 0;
              string userInput = Console.ReadLine().ToLower().Trim();
                switch (userInput)
                {
                    case "r":
                    case "rock":
                        return Roshambo.Rock;
                        break;
                    case "p":
                    case "paper":
                        return Roshambo.Paper;
                        break;
                    case "s":
                    case "scissor":
                        return Roshambo.Scissors;
                        break;
                }

            return (Roshambo)i;
        }
    }
}
