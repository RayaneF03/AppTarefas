using AppTarefas.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppTarefas.Controllers
{
    public class TarefasController : Controller
    {
        // Lista em memória(grava as informações apenas quando a aplicação está rodando)
        private static List<Tarefa> _tarefas = new List<Tarefa>();
        private static int _proximoId = 1;

        // GET: Tarefas
        public IActionResult Index()
        {
            return View(_tarefas); // Envia a lista de tarefas como parametro para a pagina Index.
        }

        // GET: Tarefas/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                tarefa.TarefaID = _proximoId++;
                _tarefas.Add(tarefa);
                return RedirectToAction("Index"); // Redireciona para a ação Index após criar a tarefa.
            }
            return View(tarefa);
        }
    }
}
