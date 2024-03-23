using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoList.Models;
using ToDoList.Models.ToDoTask;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<ToDoTaskViewModel> toDoTaskViewModels = new List<ToDoTaskViewModel>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var items = toDoTaskViewModels.ToList();
            return View(items);
        }

        public IActionResult AddTask(string taskName, string taskStart, string taskEnd, string taskStatus, string taskDesc)
        {
            ToDoTaskViewModel task= new ToDoTaskViewModel 
            {
                Id = Guid.NewGuid(),
                Name = taskName,
                StartDay = taskStart,
                EndDay = taskEnd,
                Status = taskStatus,
                Description = taskDesc
            };
            toDoTaskViewModels.Add(task);
            return RedirectToAction("Index");
        }
    }
}
