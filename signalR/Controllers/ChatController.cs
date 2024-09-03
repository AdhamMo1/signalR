using Microsoft.AspNetCore.Mvc;

namespace signalR.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
