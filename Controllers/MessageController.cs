using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using WebApp.Domain;
using WebApp.Domain.Entities;
using WebApp.Service;

namespace WebApp.Controllers
{
    public class MessageController : Controller
    {
        private readonly DataManager dataManager;
        public MessageController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.TextFields.GetTextFieldByCodeWord("Message"));
        }
        [HttpPost]
        public IActionResult Index(Message model)
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
