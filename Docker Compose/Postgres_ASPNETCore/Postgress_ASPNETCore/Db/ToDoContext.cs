using Microsoft.EntityFrameworkCore;
using Postgress_ASPNETCore.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Postgress_ASPNETCore.Db
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ToDo> ToDos { get; set; }
    }
}
