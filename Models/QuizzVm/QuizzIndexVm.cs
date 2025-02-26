namespace Quizzer.Models.QuizzVm;

public class QuizzIndexVm
{
	public ICollection<QuizzVm> Quizzes { get; set; } = [];

	public static QuizzIndexVm FromEntities(ICollection<Data.Entities.Quizz> quizzes) =>
		new()
		{
			Quizzes = quizzes.Select(QuizzVm.FromEntity).ToList()
		};
	
	public class QuizzVm
	{
		public Guid Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		public static QuizzVm FromEntity(Data.Entities.Quizz quizz) =>
			new()
			{
				Id = quizz.Id,
				Title = quizz.Title,
				Description = quizz.Description,
			};
	}
}