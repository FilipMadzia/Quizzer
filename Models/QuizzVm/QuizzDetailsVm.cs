using Quizzer.Data.Entities;
using Quizzer.Models.QuestionVm;

namespace Quizzer.Models.QuizzVm;

public class QuizzDetailsVm
{
	public Guid Id { get; set; }
	public string Title { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public ICollection<QuestionIndexVm> Questions { get; set; } = [];

	public static QuizzDetailsVm FromEntity(Quizz quizz) =>
		new()
		{
			Id = quizz.Id,
			Title = quizz.Title,
			Description = quizz.Description,
			Questions = quizz.Questions.Select(QuestionIndexVm.FromEntity).ToList()
		};
}