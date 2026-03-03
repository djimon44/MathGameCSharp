using MathGame.Models;
using MathGame.Enums;

namespace MathGame.Interfaces;

public interface IQuestionGenerator
{
    MathQuestion Generate(GameType game, DifficultySettings difficulty);
}
