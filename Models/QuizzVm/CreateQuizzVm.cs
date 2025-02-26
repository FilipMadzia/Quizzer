using System.ComponentModel.DataAnnotations;
using Quizzer.Data.Entities;
using Quizzer.Models.QuestionVm;

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
}