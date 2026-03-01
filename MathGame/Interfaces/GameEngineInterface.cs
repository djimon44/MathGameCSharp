using MathGame.Models;
using MathGame.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame.Interfaces
{
    internal interface GameEngineInterface
    {
        GameSession Play(Operation operation);
    }
}
