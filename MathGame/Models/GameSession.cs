using System;
using System.Collections.Generic;
using System.Text;

using MathGame.Enums;

namespace MathGame.Models
{
    public class GameSession
    {
        // Fields:
        public DateTime PlayedOn { get; }
        public Operation Operation { get; }
        public int Score { get; }
        public int TotalQuestions { get; }

        // Constructor
        public GameSession(Operation operation, int score, int  totalQuestions)
        {
            PlayedOn = DateTime.Now;
            Operation = operation;
            Score = score;
            TotalQuestions = totalQuestions;
        }
    }
}
