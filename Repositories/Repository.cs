using Microsoft.EntityFrameworkCore;
using Quizzer.Data;
using Quizzer.Data.Entities;

namespace Quizzer.Repositories;

public abstract class Repository<T>(ApplicationDbContext context) : IRepository<T> where T : Entity
{
	public async Task<ICollection<T>> GetAllAsync() => await context.Set<T>()
		.OrderBy(x => x.CreatedAt)
		.ToListAsync();
	
	public async Task<T?> GetByIdAsync(Guid id) => await context.Set<T>().FindAsync(id);

	public async Task AddAsync(T entity)
	{
		await context.Set<T>().AddAsync(entity);
		await context.SaveChangesAsync();
	}

	public async Task UpdateAsync(T entity)
	{
		entity.UpdatedAt = DateTime.UtcNow;
		
		context.Update(entity);
		await context.SaveChangesAsync();
	}

	public async Task DeleteAsync(T entity)
	{
		context.Set<T>().Remove(entity);
		await context.SaveChangesAsync();
	}
}