// See https://aka.ms/new-console-template for more information
using RoshamboLab;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Xml.Linq;

Console.WriteLine("*****Welcome to Rock Paper Scissors!******");
Console.Write("Enter your name :\t");

HumanPlayer humanPlayer = new HumanPlayer();
int humanWin = 0, opponentWin = 0, draw = 0;

humanPlayer.Name = Console.ReadLine().Trim();

Player opponentPlayer;

    string opponentChoice = Validator.ValidateOtherPlayer();
    opponentPlayer = opponentChoice == "j" ? new RockPlayer() : new RandomPlayer();
    opponentPlayer.Name = opponentChoice == "j" ? "The Jets" : "The Sharks";


do
{
        humanPlayer.Value = humanPlayer.GenerateRoshambo();
        opponentPlayer.Value = opponentPlayer.GenerateRoshambo();

        Console.WriteLine($"{humanPlayer.Name}      \t {humanPlayer.Value}");
        Console.WriteLine($"{opponentPlayer.Name}    \t {opponentPlayer.Value}");

        if (humanPlayer.Value == opponentPlayer.Value) 
        {
            Console.WriteLine("Draw!");
            draw++; 
        }
        else if ((humanPlayer.Value == Roshambo.Rock && opponentPlayer.Value == Roshambo.Scissors) ||
             (humanPlayer.Value == Roshambo.Paper && opponentPlayer.Value == Roshambo.Rock) ||
             (humanPlayer.Value == Roshambo.Scissors && opponentPlayer.Value == Roshambo.Paper))
        {
            Console.WriteLine($"{humanPlayer.Name} wins!");
            humanWin++;
        }
        else
        {
            Console.WriteLine($"{opponentPlayer.Name} wins!");
            opponentWin++;
        }

} while (Validator.GetPlayAgainAnswer() == true);

Console.WriteLine($"{humanPlayer.Name} Win : {humanWin} Lost : {opponentWin} Draw : {draw}" );

