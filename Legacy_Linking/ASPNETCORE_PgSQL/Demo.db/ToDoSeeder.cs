using Demo.db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo.db
{
    public class ToDoSeeder
    {
        private readonly ToDoContext _db;

        public ToDoSeeder(ToDoContext db)
        {
            _db = db;
        }

        public async Task Seed()
        {
            _db.Database.Migrate();

            if (!_db.ToDos.Any())
            {
                _db.ToDos.Add(new ToDo
                {
                    Item = "1Workout",
                });
                _db.ToDos.Add(new ToDo
                {
                    Item = "1Cook",
                });
                _db.ToDos.Add(new ToDo
                {
                    Item = "1Read a book",
                });
                _db.SaveChanges();
            }
        }
    }
}
