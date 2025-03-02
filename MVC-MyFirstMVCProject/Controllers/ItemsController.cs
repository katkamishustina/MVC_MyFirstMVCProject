using Microsoft.AspNetCore.Mvc;
using MVC_MyFirstMVCProject.Models;

namespace MVC_MyFirstMVCProject.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item = new Item() {Name = "Keyboard"};
            return View(item);
        }
        
        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}
