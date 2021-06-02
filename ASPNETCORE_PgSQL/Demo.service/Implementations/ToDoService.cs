using demo.repository.Interfaces;
using Demo.db.Entities;
using Demo.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.service.Implementations
{
    public class ToDoService: IToDoService
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository repository) 
        {
            _toDoRepository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IEnumerable<ToDo> GetAllToDos()
        {
            return _toDoRepository.GetAllToDos();
        }
    }
}
