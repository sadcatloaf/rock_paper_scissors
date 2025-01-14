using System.Reflection.Metadata;
// using rock_paper_scissors.models;

namespace rock_paper_scissors;

public class Game
{
    private string userChoice;
    private string computerChoice;


    public Game()
    {
        userChoice = string.Empty;
        computerChoice = string.Empty;
        Console.WriteLine("Game is starting");
        PlayGame();
    }

    public void GetUserChoice()
    {
        Console.WriteLine("Enter your choice:(rock,paper,scissors)");
        userChoice = Console.ReadLine();
        if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
        {
            System.Console.WriteLine("Bad Choice");
            GetUserChoice();
        }
        // throw new Exception("You must enter a choice:(rock,paper,scissors)");
    }

    public void GetComputerChoice()
    {
        //NOTE - uses random number to make a choice
        Random random = new Random();
        //NOTE - creates number on choice from 0 to 3
        int choice = random.Next(0, 3);
        //NOTE - evaluates the number expression so instead of writing an if else statement you can use switch to select one of many code blocks to be executed 
        computerChoice = choice switch
        {
            0 => "rock",
            1 => "paper",
            2 => "scissors",
            _ => "rock",
        };
    }

    public void Winner()
    {
        Console.WriteLine($"You chose: {userChoice}");
        Console.WriteLine($"Computer chose: {computerChoice}");
        //NOTE - this means if you pick the same it comes to a draw and nobody wins
        if (userChoice == computerChoice)
        {
            Console.WriteLine("It's a draw!");
        }
        //NOTE - || is similar to && in this property; it'll only evaluate the second operand if the first evaluates to false.
        //NOTE - && is short-circuit logical operator. For AND operations if any of the operand evaluated to false then total expression evaluated to false, so there is no need to evaluate remaining expression, similarly in OR operation if any of the operand evaluated to true then remaining evaluation can be skipped
        else if ((userChoice == "rock" && computerChoice == "scissors") ||
        (userChoice == "scissors" && computerChoice == "paper") ||
        (userChoice == "paper" && computerChoice == "rock"))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Computer wins!");
        }
    }

    //NOTE - Methods to run the game
    public void PlayGame()
    {
        GetUserChoice();
        GetComputerChoice();
        Winner();
    }

}