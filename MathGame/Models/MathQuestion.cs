using System;
using System.Collections.Generic;
using System.Text;

using MathGame.Enums;

namespace MathGame.Models
{
    public class MathQuestion
    {
        // Fields:
        public int OperandA { get; }
        public int OperandB { get; }
        public Operation Operation {  get; }
        public int CorrectAnswer { get; }
        public int? PlayerAnswer { get; private set; } // ? means it can be null; private set means only changable within the class

        public bool isAnswered
        {
            get { return PlayerAnswer.HasValue; }
        }

        public bool isCorrect
        {
            get { return isAnswered && (PlayerAnswer == CorrectAnswer); }
        }
        
        
        // Constructor:
        public MathQuestion(int operandA, int operandB, Operation operation)
        {
            OperandA = operandA;
            OperandB = operandB;
            Operation = operation;
            CorrectAnswer = ComputeAnswer();
        }

        // Methods:

        public void RecordAnswer(int answer)
        {
            this.PlayerAnswer = answer;
        }

        private int ComputeAnswer() {
            switch (Operation) {
                case Operation.ADDITION:
                    return OperandA + OperandB;
                case Operation.SUBSTRACTION: 
                    return OperandA - OperandB;
                case Operation.MULTIPLICATION:
                    return OperandA * OperandB;
                case Operation.DIVISION:
                    return OperandA / OperandB;

                default:
                    throw new InvalidOperationException("That operation is not supported.");
            }
        }
    }
}
