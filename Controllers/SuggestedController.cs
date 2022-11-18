using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;
using WebApp.Domain.Entities;
using WebApp.Service;
using System;
using System.Linq;

namespace WebApp.Controllers
{
    public class SuggestedController : Controller
    {
        private readonly DataManager dataManager;
        private readonly AppDbContext context;
        public SuggestedController(DataManager dataManager, AppDbContext context)
        {
            this.context = context;
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            var entity = id == default ? new NewsItem() : dataManager.NewsItems.GetNewsItemById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(NewsItem model)
        {
            if (ModelState.IsValid)
            {
                dataManager.NewsItems.SaveNewsItem(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        public IActionResult CheckReviews(string AuthMail)
        {
            var newsItem = context.NewsItems.FirstOrDefault(item => item.Email == AuthMail && item.IsApproved == false);

            if (newsItem != null)
            {
                ViewBag.Message = newsItem.Review;
                return View();
            }

            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
