using MathGame.Interfaces;
using MathGame.Enums;
using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame.Services
{
    public class QuestionGenerator : IQuestionGenerator
    {
        private readonly Random _random = new Random();

        public MathQuestion Generate(GameType game)
        {
            return game == GameType.Division
                ? GenerateDivision()
                : GenerateStandart(game);
        }

        private MathQuestion GenerateStandart(GameType game)
        {
            int a = _random.Next(1, 101);
            int b = _random.Next(1, 101);
            return new MathQuestion(a, b, game);
        }

        private MathQuestion GenerateDivision()
        {
            int divisor = _random.Next(1, 11);
            int quotient = _random.Next(1, 11);
            int dividend = divisor * quotient;
            return new MathQuestion(dividend, divisor, GameType.Division);
        }
    }
}
