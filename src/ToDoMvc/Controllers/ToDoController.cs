using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoMvc.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            var vm = new Models.View.ToDoViewModel()
            {
                Items = new List<Models.ToDoItem>()


                {
                    new Models.ToDoItem{
                    Id = Guid.NewGuid(),
                    Title = "Item 1",
                    DueAt = DateTime.Now
                    },

                    new Models.ToDoItem{
                    Id = Guid.NewGuid(),
                    Title = "Item 2",
                    DueAt = DateTime.Now
                    },

                    new Models.ToDoItem{
                    Id = Guid.NewGuid(),
                    Title = "Item 3",
                    DueAt = DateTime.Now
                    }
                }


            };

            return View(vm);
        }
    }
}