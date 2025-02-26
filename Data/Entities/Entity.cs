using System.ComponentModel.DataAnnotations;

namespace Quizzer.Data.Entities;

public abstract class Entity
{
	[Key]
	public Guid Id { get; private set; } = Guid.NewGuid();
	public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
	public DateTime? UpdatedAt { get; set; }
}