using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quizzer.Data.Entities;

namespace Quizzer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Quizz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
