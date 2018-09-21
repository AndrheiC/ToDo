using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoMvc.Data;
using ToDoMvc.Models;

namespace ToDoMvc.Services
{
    public class ToDoItemService : IToDoItemService
    {
        private readonly ApplicationDbContext _context;

        public ToDoItemService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync()
        {
            return await _context.Items.Where(i => !i.IsDone).ToArrayAsync();
            throw new NotImplementedException();
        }
    }
}
