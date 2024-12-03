// See https://aka.ms/new-console-template for more information
using RoshamboLab;
using System;
using System.ComponentModel.Design;

Console.WriteLine("*****Welcome to Rock Paper Scissors!******");
Console.WriteLine("Enter your name");
HumanPlayer humanPlayer = new HumanPlayer();
RockPlayer rockPlayer = new RockPlayer();
RandomPlayer randPlayer = new RandomPlayer();

humanPlayer.Name = Console.ReadLine().Trim();
int flag = 0;
bool isValid = false;

Console.WriteLine("Would you like to play against The Jets or The Sharks (j/s)?: ");
string opponent = "";



while (isValid == false)
{
    opponent = Console.ReadLine().ToLower().Trim();
    switch (opponent)
    {
        case "j":
        case "%jet":
            rockPlayer.Name = "The Jets";
            flag = 1;
            break;
        case "s":
        case "%shark":
            randPlayer.Name = "The Sharks";
            flag = 2;
            break;
        default:
            Console.WriteLine("Enter Valid Input");
            flag = 3;
            break;          
    }
    if (flag != 3)
    {
        isValid = true;
    }
 
}
int humanWin = 0, humanLoss = 0;
int rockWin = 0, rockLoss = 0;
int randWin = 0, randLoss = 0;
do
{
    Console.WriteLine("Rock, paper, or scissors? (R/P/S): ");
    isValid = false;

    while (isValid == false)
    {
        humanPlayer.Value = humanPlayer.GenerateRoshambo();
        if (humanPlayer.Value == 0)
        {
            Console.WriteLine("Enter Valid Input");
        }
        else
        {
            isValid = true;
        }
    }

    Console.WriteLine($"{humanPlayer.Name}      \t {humanPlayer.Value}");
    if (flag == 1)
    {
        rockPlayer.Value = rockPlayer.GenerateRoshambo();
        Console.WriteLine($"{rockPlayer.Name}    \t {rockPlayer.Value}");
        switch(humanPlayer.Value)
        {
            case Roshambo.Rock:
                Console.WriteLine("Draw");
                break;
            case Roshambo.Paper:
                Console.WriteLine($"{humanPlayer.Name}    Wins");
                humanWin = humanWin + 1;
                rockLoss = rockLoss + 1;
                break;
            case Roshambo.Scissors:
                Console.WriteLine($"{rockPlayer.Name}     Wins");
                rockWin = rockWin + 1;
                humanLoss = humanLoss + 1;
                break;
        }
    }
    if (flag == 2)
    {
        randPlayer.Value = randPlayer.GenerateRoshambo();
        Console.WriteLine($"{randPlayer.Name}     \t {randPlayer.Value}");
        switch (humanPlayer.Value)
        {
            case Roshambo.Rock:
                if (randPlayer.Value == Roshambo.Rock) { Console.WriteLine("Draw"); }
                else if (randPlayer.Value == Roshambo.Paper)
                { 
                    Console.WriteLine($"{randPlayer.Name}   Wins"); randWin = randWin + 1; humanLoss = humanLoss + 1;
                }
                else if (randPlayer.Value == Roshambo.Scissors)
                { 
                    Console.WriteLine($"{humanPlayer.Name}   Wins"); humanWin = humanWin + 1; randLoss = randLoss + 1;
                }
                break;
            case Roshambo.Paper:
                if (randPlayer.Value == Roshambo.Rock) 
                { 
                    Console.WriteLine($"{humanPlayer.Name}   Wins"); humanWin = humanWin + 1; randLoss += 1;
                }
                else if (randPlayer.Value == Roshambo.Paper) 
                { Console.WriteLine("Draw"); }
                else if (randPlayer.Value == Roshambo.Scissors) 
                { 
                    Console.WriteLine($"{randPlayer.Name}     Wins"); randWin = randWin + 1; humanLoss += 1; 
                }
                break;
            case Roshambo.Scissors:
                if (randPlayer.Value == Roshambo.Rock) 
                { 
                    Console.WriteLine($"{randPlayer.Name}    Wins"); randWin = randWin + 1; humanLoss += 1;
                }
                else if (randPlayer.Value == Roshambo.Paper) 
                { 
                    Console.WriteLine($"{humanPlayer.Name}   Wins"); humanWin = humanWin + 1; randLoss = randLoss + 1;
                }
                else if (randPlayer.Value == Roshambo.Scissors) { Console.WriteLine("Draw"); }
                break;
        }
    }

} while (GetPlayAgainAnswer() == true);

Console.WriteLine($"{humanPlayer.Name} Win : {humanWin} Lost : {humanLoss}");
if (flag == 1)
{ 
    Console.WriteLine($"{rockPlayer.Name} Win : {rockWin} Lost : {rockLoss}"); 
}
if (flag == 2)
{ 
    Console.WriteLine($"{randPlayer.Name} Win : {randWin} Lost : {randLoss}");
}


bool GetPlayAgainAnswer(string strMessage = "Would you like to Continue? y/n")
{
    Console.WriteLine(strMessage);
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower().Trim() != "y")
    {
        return false;
    }
    return true;
}