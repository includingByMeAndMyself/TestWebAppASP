using Microsoft.AspNetCore.Mvc;
using TestWebApp.Domain;

namespace TestWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManage;

        public HomeController(DataManager dataManager)
        {
            this.dataManage = dataManager; 
        }
        public IActionResult Index()
        {
            return View(dataManage.ServiceItems.GetServiceItems());
        }
    }
}
