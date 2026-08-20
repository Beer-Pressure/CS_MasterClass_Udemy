internal class Quiz
{
    private Question[] questions;

    public Quiz(Question[] questions)
    {
        this.questions = questions;
    }

    public void DisplayQuestion(Question question)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("====================================");
        Console.WriteLine("              Question              ");
        Console.WriteLine("====================================");

        Console.ResetColor();
        Console.WriteLine(question.QuestionText);

        int answerIndex = 1;

        foreach (string answer in question.Answers)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("   ");
            Console.Write(answerIndex++);
            Console.ResetColor();
            Console.WriteLine($". {answer}");
        }
    }
}