# MathGame

A console-based math quiz game built with C# and .NET 10. Practice arithmetic with timed questions across multiple difficulty levels.

## Features

- **5 game modes**: Addition, Subtraction, Multiplication, Division, and Random
- **3 difficulty levels** with different number ranges and time limits
- **Timed questions** — each question has a countdown based on difficulty
- **Game history** — view all past sessions with scores and completion times

## Difficulty Levels

| Level  | Number Range | Time per Question |
|--------|-------------|-------------------|
| Easy   | 1–10        | 60 seconds        |
| Medium | 1–20        | 90 seconds        |
| Hard   | 1–35        | 90 seconds        |

## How to Play

Each game consists of **5 questions**. You earn 1 point per correct answer within the time limit. Maximum score: 5/5.

- Answer with a whole number and press Enter
- If time runs out, the question is marked as incorrect
- After 5 questions, your score and total time are displayed

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## Getting Started

```bash
# Clone the repository
git clone https://github.com/your-username/MathGameCSharp.git
cd MathGameCSharp

# Run the game
dotnet run --project MathGame/MathGame.csproj
```

## Project Structure

```
MathGameCSharp/
├── MathGame/
│   ├── Enums/
│   │   ├── GameType.cs           # Game mode definitions
│   │   └── Difficulty.cs         # Difficulty level definitions
│   ├── Interfaces/
│   │   ├── IGameEngine.cs        # Game execution contract
│   │   └── IQuestionGenerator.cs # Question generation contract
│   ├── Models/
│   │   ├── MathQuestion.cs       # Question with answer tracking
│   │   ├── GameSession.cs        # Session result record
│   │   └── DifficultySettings.cs # Difficulty parameters
│   ├── Services/
│   │   ├── GameEngine.cs         # Game flow orchestration
│   │   ├── QuestionGenerator.cs  # Question creation logic
│   │   └── GameHistory.cs        # In-memory session history
│   ├── UI/
│   │   └── ConsoleUI.cs          # Console input/output
│   └── Program.cs                # Entry point
└── MathGame.slnx
```

## Menu Options

| Input | Action              |
|-------|---------------------|
| `1`   | Addition            |
| `2`   | Subtraction         |
| `3`   | Multiplication      |
| `4`   | Division            |
| `R`   | Random operation    |
| `5`   | View game history   |
| `0`   | Exit                |
