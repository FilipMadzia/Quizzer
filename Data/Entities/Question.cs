namespace Quizzer.Data.Entities;

public class Question : Entity
{
	public string QuestionText { get; set; } = string.Empty;
	public string[] Answers { get; set; } = new string[4];
	public int CorrectAnswerIndex { get; set; }
}