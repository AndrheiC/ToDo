using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoMvc.Services;

namespace ToDoMvc.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoItemService _toDoItemService;

        public ToDoController(IToDoItemService service)
        {
            _toDoItemService = service;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new Models.View.ToDoViewModel()
            {
                Items = await _toDoItemService.GetIncompleteItemsAsync()
            };

            return View(vm);
        }
    }
}