using System;

void Rock()
{
    Console.WriteLine($@"
    _______
-- - '   ____)
      (_____)
      (_____)
      (____)
-- -.__(___)
");
}

void Paper()
{
    Console.WriteLine($@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
");
}

void Scissors()
{
    Console.WriteLine($@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
    ");
}

bool gameLoop = true;
int userPoints = 0;
int computerPoints = 0;
while (gameLoop)
// Game();
// void Game()
{

    Console.WriteLine("-----------------------------");
    Console.WriteLine($"|Player: {userPoints} | Computer: {computerPoints} |");
    Console.WriteLine("-----------------------------");
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");


    string userChoice = Console.ReadLine();

    Random randomChoice = new Random();
    int computerChoice = randomChoice.Next(1, 4);
    if (string.IsNullOrEmpty(userChoice))
    {
        Console.WriteLine("Please enter a valie number");
    }
    else
    {
        switch (computerChoice)
        {
            case 1:
                if (userChoice == "1")
                {

                    //this is a tie
                    Rock();
                    Rock();
                    Console.WriteLine("It is a tie.");
                }

                else if (userChoice == "2")
                {
                    Paper();
                    Rock();
                    Console.WriteLine("User wins");
                    userPoints++;
                }
                else if (userChoice == "3")
                {
                    Scissors();
                    Rock();
                    Console.WriteLine("Computer wins");
                    computerPoints++;
                }
                break;
            case 2:
                if (userChoice == "1")
                {

                    //this is a tie
                    Rock();
                    Rock();
                    Console.WriteLine("It is a tie");
                }

                else if (userChoice == "2")
                {
                    Paper();
                    Rock();
                    Console.WriteLine("User wins");
                    userPoints++;
                }
                else if (userChoice == "3")
                {
                    Scissors();
                    Rock();
                    Console.WriteLine("Computer wins");
                    computerPoints++;
                }
                break;
            case 3: //computer chose scissors
                if (userChoice == "1")
                {

                    //this is a tie
                    Rock();
                    Scissors();
                    Console.WriteLine("User wins.");
                    userPoints++;
                }

                else if (userChoice == "2")
                {
                    Paper();
                    Scissors();
                    Console.WriteLine("Computer wins");
                    computerPoints++;
                }
                else if (userChoice == "3")
                {
                    Scissors();
                    Scissors();
                    Console.WriteLine("It is a tie");
                }
                break;
        }
    }

    // Console.WriteLine("Do you wish to play again?");
    // Console.WriteLine("Enter Y or N");

    // if (playAgain == "N" || playAgain == "n" || playAgain == "no")
    // {
    //     gameLoop = false;
    //     Console.WriteLine($"User has {userPoints} points - Computer has {computerPoints} points");
    // }
};