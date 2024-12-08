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
            string userInput = Validator.ValidateHumanRoshambo();
                switch (userInput)
                {
                    case "r":
                    case "rock":
                        Value = Roshambo.Rock;
                        break;
                    case "p":
                    case "paper":
                        Value = Roshambo.Paper;
                        break;
                    case "s":
                    case "scissor":
                        Value = Roshambo.Scissors;
                        break;
                }
            return Value;

        }
    }
}
 