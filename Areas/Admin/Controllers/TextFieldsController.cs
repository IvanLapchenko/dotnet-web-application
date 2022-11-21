using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApp.Domain;
using WebApp.Domain.Entities;
using WebApp.Service;


namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TextFieldsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly AppDbContext context;
        public TextFieldsController (DataManager dataManager, AppDbContext context)
        {
            this.dataManager = dataManager;
            this.context = context;
        }

        public IActionResult Edit(string codeWord)
        {
            var entity = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(TextField model)
        {
            if (ModelState.IsValid)
            {
                var entity = context.TextFields.First(a => a.CodeWord == "PageIndex");
                entity.Text = ViewBag.Text;
                context.SaveChanges();
                //dataManager.TextFields.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }

        public IActionResult EditContacts(string codeWord)
        {
            var entity = dataManager.TextFields.GetTextFieldByCodeWord(codeWord);
            return View(entity);
        }
        [HttpPost]
        public IActionResult EditContacts(TextField model)
        {
            if (ModelState.IsValid)
            {
                var entity = context.TextFields.First(a => a.CodeWord == "PageContacts");
                entity.Text = ViewBag.Text;
                context.SaveChanges();
                //dataManager.TextFields.SaveTextField(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).CutController());
            }
            return View(model);
        }
    }
}
