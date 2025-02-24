using Quizzer.Data.Entities;

namespace Quizzer.Models.QuizzViewModels;

public class DetailsVm : IDetailsVm<DetailsVm, Quizz>
{
	public Guid Id { get; set; }
	public string Title { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public static DetailsVm FromEntity(Quizz quizz) =>
		new()
		{
			Id = quizz.Id,
			Title = quizz.Title,
			Description = quizz.Description,
		};
}