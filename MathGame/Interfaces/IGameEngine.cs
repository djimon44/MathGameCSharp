using MathGame.Models;
using MathGame.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame.Interfaces
{
    public interface IGameEngine
    {
        GameSession Play(GameType game);
    }
}
