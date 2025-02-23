using Quizzer.Data;
using Quizzer.Data.Entities;

namespace Quizzer.Repositories;

public class QuestionRepository(ApplicationDbContext context) : Repository<Question>(context) { }