using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Domain;

namespace WebApp.Controllers
{
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly AppDbContext context;
        public NewsController(DataManager dataManager, AppDbContext context)
        {
            this.dataManager = dataManager;
            this.context = context;
        }

        public IActionResult Index(Guid id)
        {
            //if (dataManager.NewsItems.GetNewsItemById(id).IsApproved == true) 
            {
                if (id != default)
                {
                    return View("Show", dataManager.NewsItems.GetNewsItemById(id));
                }

                ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWord("PageNews");
                return View(dataManager.NewsItems.GetNewsItems());
            }
            
        }
    }
}
