using Quizzer.Data.Entities;

namespace Quizzer.Models;

public interface IDetailsVm<out T, in TEntity> where T : class where TEntity : Entity
{
	static abstract T FromEntity(TEntity entity);
}