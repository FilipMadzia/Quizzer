using Quizzer.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Quizzer.Models.QuizzViewModels;

public class CreateVm : ICreateVm<Quizz>
{
	[Required]
	public string Title { get; set; } = string.Empty;
	[Required]
	public string Description { get; set; } = string.Empty;

	public Quizz ToEntity()
	{
		return new Quizz()
		{
			Title = Title,
			Description = Description
		};
	}
}