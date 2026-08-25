internal class Test
{
    
}

internal struct TestStruct
{
    public int a;
    public int b;
}

internal class Program
{
    static void Main()
    {
        TestStruct ts;

        ts.a = 1;
        ts.b = 2;

        //Console.WriteLine(ts)

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