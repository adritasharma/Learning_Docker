using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {

        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService repository)
        {
            _toDoService = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var res = _toDoService.GetAllToDos();
            return Ok(res);
        }

    }
}