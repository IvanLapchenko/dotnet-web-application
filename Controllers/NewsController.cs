﻿using System;
using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;

namespace WebApp.Controllers
{
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;
        public NewsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
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
