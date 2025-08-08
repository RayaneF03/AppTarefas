using Microsoft.AspNetCore.Mvc;

namespace AppTarefas.Controllers
{
    public class Tarefas : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
