using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using MathGame.Enums;
using MathGame.Interfaces;
using MathGame.Models;
using MathGame.UI;


namespace MathGame.Services
{
    public class GameEngine : IGameEngine 
    {
        private const int TotalQuestions = 5;

        private readonly QuestionGenerator _generator;
        private readonly ConsoleUI _ui;

        // Dependecy injection 
        public GameEngine(QuestionGenerator generator, ConsoleUI ui) 
        {
            _generator = generator;
            _ui = ui;
        }

        public GameSession Play(GameType game)
        {
            int score = 0;
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < TotalQuestions; i++)
            {
                MathQuestion question = _generator.Generate(game);

                _ui.DisplayQuestion(question, i + 1, TotalQuestions);
                int playerAnswer = _ui.GetPlayerAnswer();
                question.RecordAnswer(playerAnswer);

                if (question.isCorrect)
                {
                    score++;
                    _ui.DisplayFeedback(correct: true);
                }
                else
                {
                    _ui.DisplayFeedback(correct: false, question.CorrectAnswer);
                }
            }

            sw.Stop();

            var session = new GameSession(game, score, TotalQuestions, sw.Elapsed);
            _ui.DisplaySummary(session);
            return session;
        }
    }
}
