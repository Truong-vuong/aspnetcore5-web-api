using aspnetcore5_web_api.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore5_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatagoriesController : ControllerBase
    {
        private readonly MyDbContext _context;

        public CatagoriesController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var catagories = _context.Catagories.ToList();
            return Ok(catagories);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var catagory = _context.Catagories.SingleOrDefault(catagory => catagory.catagoryId == id);
            if(catagory == null)
            {
                return NotFound();
            }
            return Ok(catagory);

        }
    }
}
