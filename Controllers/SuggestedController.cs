using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;
using WebApp.Domain.Entities;
using WebApp.Service;
using System;


namespace WebApp.Controllers
{
    public class SuggestedController : Controller
    {
        private readonly DataManager dataManager;
        public SuggestedController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            var entity = id == default ? new Suggested() : dataManager.Suggested.GetSuggestedById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Suggested model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Suggested.SaveSuggested(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
