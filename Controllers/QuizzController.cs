using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging;
using Quizzer.Models.QuizzVm;
using Quizzer.Repositories;

namespace Quizzer.Controllers;

[Route("[controller]es/[action]")]
public class QuizzController(QuizzRepository repository) : Controller
{
	public async Task<IActionResult> Index()
	{
		var entities = await repository.GetAllAsync();
		
		var model = new QuizzIndexVm(entities);
		
		return View(model);
	}

	public async Task<IActionResult> Details(Guid id)
	{
		var entity = await repository.GetByIdAsync(id);
		
		if (entity == null)
			return NotFound();
		
		entity.Questions.AddRange(
		[
			new()
			{
				QuestionText = "Test 1",
				Answers =
				[
					"Wrong 1",
					"Wrong 2",
					"Wrong 3",
					"Correct"
				],
				CorrectAnswerIndex = 3
			},
			new()
			{
				QuestionText = "Test 2",
				Answers =
				[
					"Wrong 1",
					"Correct",
					"Wrong 2",
					"Wrong 3"
				],
				CorrectAnswerIndex = 1
			}
		]);
		
		var model = new QuizzDetailsVm(entity);
		
		return View(model);
	}

	public IActionResult Create()
	{
		var model = new CreateQuizzVm();

		return View(model);
	}

	[HttpPost]
	public async Task<IActionResult> Create(CreateQuizzVm model)
	{
		var entity = model.ToEntity();
		
		await repository.AddAsync(entity);
		
		return RedirectToAction(nameof(Index));
	}
}