using System.ComponentModel.DataAnnotations;

namespace Quizzer.Data.Entities;

public class Quizz : Entity
{
	[StringLength(100)]
	public string Title { get; set; } = string.Empty;
	[StringLength(300)]
	public string Description { get; set; } = string.Empty;

	public ICollection<Question> Questions { get; set; } = [];
}