using MathGame.Models;
using MathGame.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace MathGame.Interfaces
{
    public interface IQuestionGenerator
    {
        MathQuestion Generate(GameType game, DifficultySettings difficulty);
    }
}
