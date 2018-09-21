using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoMvc.Models;

namespace ToDoMvc.Services
{
    public class ToDoItemService : IToDoItemService
    {
        public Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
