using demo.repository.Interfaces;
using Demo.db;
using Demo.db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo.repository.Implementations
{
    public class ToDoRepository : IToDoRepository
    {
        protected ToDoContext _context;
        protected DbSet<ToDo> DbSet;
        public ToDoRepository(ToDoContext context) 
        {
            _context = context;
            DbSet = _context.Set<ToDo>();
        }
        public IEnumerable<ToDo> GetAllToDos()
        {
            return DbSet.AsEnumerable<ToDo>();
        }
    }
}
