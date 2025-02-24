using Microsoft.AspNetCore.Mvc;
using Quizzer.Models.QuizzViewModels;
using Quizzer.Repositories;

namespace Quizzer.Controllers;

public class QuizzController(QuizzRepository repository) : Controller
{
	public async Task<IActionResult> Index()
	{
		var entities = await repository.GetAllAsync();
		
		var models = entities.Select(DetailsVm.FromEntity).ToList();
		
		return View(models);
	}

	public async Task<IActionResult> Details(Guid id)
	{
		var entity = await repository.GetByIdAsync(id);
		
		if (entity == null)
			return NotFound();
		
		var model = DetailsVm.FromEntity(entity);
		
		return View(model);
	}

	public IActionResult Create()
	{
		var model = new CreateVm();

		return View(model);
	}

	[HttpPost]
	public async Task<IActionResult> Create(CreateVm model)
	{
		var entity = model.ToEntity();
		
		await repository.AddAsync(entity);
		
		return RedirectToAction(nameof(Index));
	}
}