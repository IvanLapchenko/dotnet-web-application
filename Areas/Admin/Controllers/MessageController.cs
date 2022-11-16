using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;
using System;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly DataManager dataManager;
        public MessageController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Index", dataManager.Message.GetMessageById(id));
            }

            return View(dataManager.Message.GetMessages());
        }
    }
}
