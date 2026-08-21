using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    internal class Answers
    {
        string[] AnswersArr = new string[4];

        public void InitializeAnswersArr()
        {
            AnswersArr[0] = "Delhi";
            AnswersArr[1] = "16";
            AnswersArr[2] = "Orange";
            AnswersArr[3] = "Oxygen";
        }

        public string GetAnswers(int index)
        {
            return AnswersArr[index];
        }
    }
}
