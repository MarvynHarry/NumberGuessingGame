
# Number Guessing Game (C# .NET CLI Application)

A simple and fun command-line-based number guessing game written in C#. The computer randomly selects a number between 1 and 100, and the player must guess it within a limited number of chances based on the selected difficulty level. Sample solution for the [Number Guessing Game](https://roadmap.sh/projects/number-guessing-game) challenge from [roadmap.sh](https://roadmap.sh/).

## Features

- **Difficulty Levels**: Choose between Easy, Medium, and Hard, which determine the number of attempts allowed:
  - **Easy**: 10 chances
  - **Medium**: 5 chances
  - **Hard**: 3 chances
- **Random Number Generation**: The game generates a random number between 1 and 100 for each round.
- **Hints and Feedback**: Players receive feedback on their guess, whether it is too high or too low. A hint is provided when the player has only one chance left.
- **Timer**: Tracks how long it takes to guess the correct number.
- **High Score Tracking**: The game keeps track of the fewest attempts it took to guess the number across rounds.
- **Multiple Rounds**: Play as many rounds as you like until you decide to quit.

## Getting Started

### Prerequisites

- .NET SDK installed on your system. You can download it from [Microsoft's .NET Download page](https://dotnet.microsoft.com/download).

### Installation

1. Clone this repository:
    ```bash
    git clone https://github.com/yourusername/NumberGuessingGame.git
    ```
2. Navigate to the project directory:
    ```bash
    cd NumberGuessingGame
    ```
3. Build the project:
    ```bash
    dotnet build
    ```

### Running the Game

To start playing the game, use the following command:
```bash
dotnet run
```

## How to Play

1. **Welcome Message**: When the game starts, you'll see a welcome message with the rules.
2. **Select Difficulty**: You will be prompted to choose a difficulty level (Easy, Medium, or Hard).
3. **Make Your Guesses**: The game will ask you to input a number between 1 and 100 to make your guess.
   - If your guess is incorrect, you will be informed whether the target number is greater or less than your guess.
   - If you are down to your last chance, a hint will be provided (whether the number is odd or even).
4. **Win or Lose**: If you guess the correct number within the given chances, you'll receive a congratulatory message and the time it took to guess.
   - If you run out of chances, the correct number will be revealed.
5. **Play Again**: After each round, you have the option to play again or quit.

## Code Structure

- `Program.cs`: The main file containing the game logic, including user input handling, random number generation, and game loop.

## Future Enhancements

Some possible features to implement in the future:
- Custom difficulty settings to allow players to set their own number of chances.
- Enhanced hint system that provides clues based on proximity to the target number.
- Saving and loading high scores across multiple sessions.

## Support My Work
If you enjoy my work or want to support what I do, feel free to [Buy Me a Coffee](https://buymeacoffee.com/marvynharry)!

## Contributing
Feel free to submit a pull request or report issues to help improve the project!

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact
For any questions or support, please reach out via [GitHub Issues](https://github.com/MarvynHarry/NumberGuessingGame/issues).

---

Enjoy playing and have fun improving your number guessing skills!
