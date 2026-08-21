namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfQuestions = 0;
            string userAnswer = "";
            Questions quesn = new Questions();
            Answers ans = new Answers();
            CheckAnswers chAns = new CheckAnswers();
            quesn.InitializeQuestionArr();
            ans.InitializeAnswersArr();
            numberOfQuestions = quesn.GetNumberOfQuestions();
            for (int i = 0; i < numberOfQuestions; i++)
            {
                quesn.PostQuestion();
                userAnswer = Console.ReadLine();
                bool isCorrect = chAns.Check(ans.GetAnswers(i), userAnswer);
                if (isCorrect)
                    Console.WriteLine($"Correct answer!\nYour score is : {chAns.GetScore()}");
                else
                    Console.WriteLine("Incorrect answer. The correct answer is : " + ans.GetAnswers(i));
            }
            Console.ReadKey();
        }
    }
}