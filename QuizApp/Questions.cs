using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp
{
    internal class Questions
    {
        string[] QuestionsArr = new string[4];
        int currentIndex = 0;

        public void InitializeQuestionArr()
        {
            QuestionsArr[0] = "What is the capital of India?";
            QuestionsArr[1] = "What is 2*8 = ?";
            QuestionsArr[2] = "What color do you get after mixing red and yellow?";
            QuestionsArr[3] = "What is the other element of water than Hydrogen?";
        }

        public void PostQuestion()
        {
            Console.WriteLine(QuestionsArr[currentIndex++]);
        }

        public int GetNumberOfQuestions()
        {
            return QuestionsArr.Length;
        }
    }
}
