using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Postgress_ASPNETCore.Reposirories;

namespace Postgress_ASPNETCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {

        private readonly IToDoRepository _toDoRepository;

        public ToDoController(IToDoRepository repository)
        {
            _toDoRepository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var res = _toDoRepository.GetAllToDos();
            return Ok(res);
        }

    }
}
