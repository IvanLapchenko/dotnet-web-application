﻿using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;
using System;
using WebApp.Domain.Entities;
using WebApp.Service;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class SuggestedController : Controller
    {
        private readonly DataManager dataManager;
        private readonly AppDbContext context;
        public SuggestedController(DataManager dataManager, AppDbContext context)
        {
            this.dataManager = dataManager;
            this.context = context;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Index", dataManager.NewsItems.GetNewsItemById(id));
            }

            return View(dataManager.NewsItems.GetNewsItems());
        }

        public IActionResult Approve(Guid id)
        {
            //var entity = context.NewsItems.FirstOrDefaultAsync(item => item.Id == id);
            //var ent = context.NewsItems.Find(id);
            //var e = context.NewsItems.FirstAsync(a => a.Id == id);
            var ent = dataManager.NewsItems.GetNewsItemById(id);
            //context.NewsItems.Update(ent);
            ent.IsApproved = true;
            context.SaveChanges();
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }

        public IActionResult Reject(Guid id)
        {
            //dataManager.NewsItems.DeleteNewsItem(id);
            var ent = dataManager.NewsItems.GetNewsItemById(id);
            ent.Review = "Your suggesting is not fit to our company";
            context.SaveChanges();
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
        }
    }
}
