using Quizzer.Data.Entities;

namespace Quizzer.Models;

public interface ICreateVm<out T> where T : Entity
{
	T ToEntity();
}