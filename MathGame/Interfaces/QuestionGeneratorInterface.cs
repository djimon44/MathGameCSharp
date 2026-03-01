using MathGame.Models;
using MathGame.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace MathGame.Interfaces
{
    internal interface QuestionGeneratorInterface
    {
        MathQuestion Generate(Operation operation);
    }
}
