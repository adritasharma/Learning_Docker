using Demo.db.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.service.Interfaces
{
    public interface IToDoService
    {
        IEnumerable<ToDo> GetAllToDos();
    }
}
