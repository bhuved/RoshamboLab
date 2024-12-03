using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class RandomPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            
            
           return (Roshambo)random.Next(1, 4);
        }
    }
}
