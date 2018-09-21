using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoMvc.Models;
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

        public async Task<IActionResult> AddItem(NewToDoItem newItem)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var succesfull = await _toDoItemService.AddItemAsync(newItem);

            if (!succesfull)
                return BadRequest(new { Error = "Could not add item"});

            return Ok();
        }
    }
}