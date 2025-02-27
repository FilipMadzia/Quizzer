using Quizzer.Data.Entities;

namespace Quizzer.Models.QuizzVm;

public class QuizzIndexVm(ICollection<Quizz> quizzes)
{
	public ICollection<QuizzVm> Quizzes { get; set; } = quizzes.Select(x => new QuizzVm(x)).ToList();
	
	public class QuizzVm(Quizz quizz)
	{
		public Guid Id { get; } = quizz.Id;
		public string Title { get; } = quizz.Title;
		public string Description { get; } = quizz.Description;
	}
}