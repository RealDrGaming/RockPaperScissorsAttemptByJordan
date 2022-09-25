const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";

bool playAgain = false;

do
{
    Console.WriteLine("Choose {r}ock, {p}aper, {s}cissors: ");
    string playerMove = Console.ReadLine();

    if (playerMove.ToLower() == "r" || playerMove.ToLower() == "rock")
    {
        playerMove = rock;
    }
    else if (playerMove.ToLower() == "p" || playerMove.ToLower() == "paper")
    {
        playerMove = paper;
    }
    else if (playerMove.ToLower() == "s" || playerMove.ToLower() == "scissors")
    {
        playerMove = scissors;
    }
    else
    {
        Console.WriteLine("Invalid input. Try again...");
        return;
    }

    Random random = new Random();
    int computerMoveRandom = random.Next(1, 4);
    string computerMove = "";

    switch (computerMoveRandom)
    {
        case 1:
            computerMove = rock;
            break;
        case 2:
            computerMove = paper;
            break;
        case 3:
            computerMove = scissors;
            break;
    }

    Console.WriteLine($"Computer played {computerMove}.");

    if ((playerMove == rock && computerMove == scissors)
        || (playerMove == paper && computerMove == rock)
        || (playerMove == scissors && computerMove == paper))
    {
        Console.WriteLine("You win!");
    }
    else if ((playerMove == rock && computerMove == rock)
        || (playerMove == paper && computerMove == paper)
        || (playerMove == scissors && computerMove == scissors))
    {
        Console.WriteLine("Draw.");
    }
    else if ((playerMove == rock && computerMove == paper)
        || (playerMove == paper && computerMove == scissors)
        || (playerMove == scissors && computerMove == rock))
    {
        Console.WriteLine("You lose.");
    }

    Console.WriteLine("Wanna play again? Yes/No");

    string playAgainString = Console.ReadLine();

    if (playAgainString.ToLower() == "y" || playAgainString.ToLower() == "yes") playAgain = true;
    else if (playAgainString.ToLower().ToLower() == "n" || playAgainString.ToLower() == "no") playAgain = false;
    else Console.WriteLine("Couldn't get that. Ending game.");
} while (playAgain);