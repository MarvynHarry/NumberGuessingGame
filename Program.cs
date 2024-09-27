using System.Diagnostics;

bool playAgain = true;
int highScore = int.MaxValue;

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");

while (playAgain)
{
    int attempts = 0;
    int numberToGuess = new Random().Next(1, 101);
    int chances = SetDifficulty();
    bool isGuessed = false;

    Console.WriteLine($"Great! Let's start the game! You have {chances} chances to guess the correct number.");
    Stopwatch timer = Stopwatch.StartNew();

    while (chances > 0 && !isGuessed)
    {
        attempts++;
        Console.Write("Enter your guess: ");
        int userGuess = GetValidNumber();

        if (userGuess == numberToGuess)
        {
            timer.Stop();
            Console.WriteLine($"Congratulations! You guessed the correct number in {attempts} attempts and took {timer.Elapsed.Seconds} seconds.");

            if (attempts < highScore)
            {
                highScore = attempts;
                Console.WriteLine($"New high score: {highScore} attempts!");
            }

            isGuessed = true;
        }
        else
        {
            chances--;
            Console.WriteLine($"Incorrect! The number is {(userGuess < numberToGuess ? "greater" : "less")} than {userGuess}.");
            Console.WriteLine($"{chances} chances remaining.");

            if (chances == 1)
            {
                Console.WriteLine("Hint: The number is " + (numberToGuess % 2 == 0 ? "even." : "odd."));
            }
        }
    }

    if (!isGuessed)
    {
        Console.WriteLine($"You've run out of chances! The correct number was {numberToGuess}.");
    }

    playAgain = AskToPlayAgain();
}

Console.WriteLine("Thank you for playing! Goodbye.");

static int SetDifficulty()
{
    Console.WriteLine("\nPlease select the difficulty level:");
    Console.WriteLine("1. Easy (10 chances)");
    Console.WriteLine("2. Medium (5 chances)");
    Console.WriteLine("3. Hard (3 chances)");
    Console.Write("Enter your choice: ");

    int choice = GetValidNumber();

    switch (choice)
    {
        case 1:
            return 10;
        case 2:
            return 5;
        case 3:
            return 3;
        default:
            Console.WriteLine("Invalid choice. Defaulting to Medium difficulty.");
            return 5;
    }
}

static int GetValidNumber()
{
    while (true)
    {
        string input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            return number;
        }
        else
        {
            Console.Write("Invalid input. Please enter a number: ");
        }
    }
}

static bool AskToPlayAgain()
{
    Console.WriteLine("\nDo you want to play again? (y/n): ");
    string input = Console.ReadLine().ToLower();
    return input == "y";
}