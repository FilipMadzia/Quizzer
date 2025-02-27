using System.ComponentModel.DataAnnotations;
using Quizzer.Data.Entities;

namespace Quizzer.Models.QuizzVm;

public class CreateQuizzVm
{
	[Required]
	public string Title { get; set; } = string.Empty;
	[Required]
	public string Description { get; set; } = string.Empty;
	public ICollection<CreateQuestionVm> Questions { get; set; } = [];

	public Quizz ToEntity() =>
		new()
		{
			Title = Title,
			Description = Description,
			Questions = Questions.Select(x => x.ToEntity()).ToList()
		};

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
}