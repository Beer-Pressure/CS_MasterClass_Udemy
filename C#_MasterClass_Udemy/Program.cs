internal class Test
{
    
}

internal static class Program
{
    static void Main()
    {
        Question[] questions = new Question[]
        {
            new Question("What is the capital of Germany?",
            new string[] {"Paris", "Berlin", "London", "Madrid"},
            1)
        };

        Quiz quiz = new Quiz(questions);

        quiz.DisplayQuestion(questions[0]);
    }
}