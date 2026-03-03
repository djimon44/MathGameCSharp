using System;
using System.Collections.Generic;
using System.Text;

namespace MathGame.Models
{
    public class DifficultySettings
    {
        public int MaxValue { get; }
        public int TimeLimitSeconds { get; }

        public DifficultySettings(int maxValue, int timeLimitSeconds)
        {
            MaxValue = maxValue;
            TimeLimitSeconds = timeLimitSeconds;
        }
    }
}
