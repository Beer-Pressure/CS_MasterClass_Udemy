internal class Question
{
    private string questionText;
    private string[] answers;
    private int correctAnswerIndex;

    public string QuestionText {  get { return questionText; } }

    public string[] Answers { get { return answers; } }

    public Question(string questionText, string[] answers, int correctAnswerIndex)
    {
        this.questionText = questionText;
        this.answers = answers;
        this.correctAnswerIndex = correctAnswerIndex;
    }

    public bool IsCorrectAnswer(int chosenIndex)
    {
        return correctAnswerIndex == chosenIndex;
    }
}