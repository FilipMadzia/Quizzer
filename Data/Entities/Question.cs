using System.ComponentModel.DataAnnotations;

namespace Quizzer.Data.Entities;

public class Question : Entity
{
	[StringLength(250)]
	public string QuestionText { get; set; } = string.Empty;
	[StringLength(50)]
	public string[] Answers { get; set; } = new string[4];
	public int CorrectAnswerIndex { get; set; }
}