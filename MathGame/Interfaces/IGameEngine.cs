using MathGame.Models;
using MathGame.Enums;

namespace MathGame.Interfaces;

public interface IGameEngine
{
    GameSession Play(GameType game, Difficulty difficulty);
}
