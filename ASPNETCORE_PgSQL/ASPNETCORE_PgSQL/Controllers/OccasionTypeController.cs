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
    public class OccasionTypeController : ControllerBase
    {

        private readonly IOccasionTypesService _occasionTypeService;

        public OccasionTypeController(IOccasionTypesService repository)
        {
            _occasionTypeService = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var res = _occasionTypeService.GetAllOccasionTypes();
            return Ok(res);
        }

    }
}