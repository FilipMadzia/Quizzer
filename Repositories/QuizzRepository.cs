using Microsoft.EntityFrameworkCore;
using Quizzer.Data;
using Quizzer.Data.Entities;

namespace Quizzer.Repositories;

public class QuizzRepository(ApplicationDbContext context) : Repository<Quizz>(context)
{
	public async Task<ICollection<Quizz>> GetAllIncludingAsync() => await context.Quizzes
			.Include(quizz => quizz.Questions)
			.ToListAsync();
}