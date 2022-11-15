using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;
using WebApp.Domain.Entities;
using WebApp.Service;
using System;

namespace WebApp.Controllers
{
    public class MessageController : Controller
    {
        private readonly DataManager dataManager;
        public MessageController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            var entity = id == default ? new Message() : dataManager.Message.GetMessageById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(Message model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Message.SaveMessage(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
