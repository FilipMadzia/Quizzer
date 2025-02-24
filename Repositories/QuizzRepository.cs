using Microsoft.EntityFrameworkCore;
using Quizzer.Data;
using Quizzer.Data.Entities;

namespace Quizzer.Repositories;

public class QuizzRepository(ApplicationDbContext context) : Repository<Quizz>(context)
{
	private readonly ApplicationDbContext _context = context;

	public async Task<ICollection<Quizz>> GetAllIncludingAsync() => await _context.Quizzes
		.OrderBy(x => x.CreatedAt)
		.Include(quizz => quizz.Questions)
		.ToListAsync();
}