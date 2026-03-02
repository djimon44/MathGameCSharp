using MathGame.Enums;
using MathGame.Models;
using MathGame.Services;
using MathGame.UI;

var ui = new ConsoleUI();
var generator = new QuestionGenerator();
var history = new GameHistory();
var engine = new GameEngine(generator, ui);

while (true)
{
    string choice = ui.ShowMainMenu();

    if (choice == "0") break;

    if (choice == "5")
    {
        ui.DisplayHistory(history.GetAll());
        continue;
    }

    GameType game;

    switch (choice)
    {
        case "1":
            game = GameType.Addition;
            break;
        case "2":
            game = GameType.Subtraction;
            break;
        case "3":
            game = GameType.Multiplication;
            break;
        case "4":
            game = GameType.Division;
            break;
        default:
            // Use a "sentinel" value to indicate something went wrong
            game = (GameType)(-1);
            break;
    }

    if ((int)game == -1)
    {
        Console.WriteLine("Invalid choice. Press any key...");
        Console.ReadKey();
        continue;
    }

    GameSession session = engine.Play(game);
    history.Add(session);
}

Console.WriteLine("Thanks for playing!");