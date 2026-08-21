using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    internal class CheckAnswers
    {
        int score = 0;
        public bool Check(string correctAnswer,string userAnswer)
        {
            if(correctAnswer == userAnswer)
            {
                score += 10;
                return true;
            }
            return false;
        }

        public int GetScore()
        {
            return score;
        }
    }
}
