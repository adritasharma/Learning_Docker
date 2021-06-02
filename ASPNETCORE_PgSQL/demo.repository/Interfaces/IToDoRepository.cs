using Demo.db.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace demo.repository.Interfaces
{
    public interface IToDoRepository
    {
        public IEnumerable<ToDo> GetAllToDos();
    }
}
