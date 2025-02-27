using Quizzer.Data.Entities;

namespace Quizzer.Models.QuizzVm;

public class QuizzDetailsVm(Quizz quizz)
{
	public Guid Id { get; } = quizz.Id;
	public string Title { get; } = quizz.Title;
	public string Description { get; } = quizz.Description;
	public ICollection<QuestionVm> Questions { get; } = quizz.Questions.Select(x => new QuestionVm(x)).ToList();

	public class QuestionVm(Question question)
	{
		public string QuestionText { get; } = question.QuestionText;
		public string[] Answers { get; } = question.Answers;
		public int CorrectAnswerIndex { get; } = question.CorrectAnswerIndex;
	}
}