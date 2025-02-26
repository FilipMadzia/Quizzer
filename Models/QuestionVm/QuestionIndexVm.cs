using Quizzer.Data.Entities;

namespace Quizzer.Models.QuestionVm;

public class QuestionIndexVm
{
	public string QuestionText { get; set; } = string.Empty;
	public string[] Answers { get; set; } = new string[4];
	public int CorrectAnswerIndex { get; set; }

	public static QuestionIndexVm FromEntity(Question question) =>
		new()
		{
			QuestionText = question.QuestionText,
			Answers = question.Answers,
			CorrectAnswerIndex = question.CorrectAnswerIndex,
		};
}