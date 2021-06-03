using Microsoft.EntityFrameworkCore;
using Postgress_ASPNETCore.Db;
using Postgress_ASPNETCore.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Postgress_ASPNETCore.Reposirories
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
