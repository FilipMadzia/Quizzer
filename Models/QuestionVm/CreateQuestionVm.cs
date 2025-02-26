using System.ComponentModel.DataAnnotations;
using Quizzer.Data.Entities;

namespace Quizzer.Models.QuestionVm;

public class CreateQuestionVm
{
	[Required]
	public string QuestionText { get; set; } = string.Empty;
	public string[] Answers { get; set; } = new string[4];
	public int CorrectAnswerIndex { get; set; }

	public Question ToEntity() =>
		new()
		{
			QuestionText = QuestionText,
			Answers = Answers,
			CorrectAnswerIndex = CorrectAnswerIndex
		};
}