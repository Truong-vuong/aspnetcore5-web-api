using aspnetcore5_web_api.Models;
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
    public class GoodsController : ControllerBase
    {
        public static List<Goods> ListGoods = new List<Goods>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(ListGoods);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                // LinQ Object query
                var g = ListGoods.SingleOrDefault(g => g.id == Guid.Parse(id));
                if (g == null)
                {
                    return NotFound();
                }
                return Ok(g);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create(GoodsVM goodsVM)
        {
            var goods = new Goods
            {
                id = Guid.NewGuid(),
                name = goodsVM.name,
                price = goodsVM.price,
            };
            ListGoods.Add(goods);
            return Ok(new { Success = true, Data = ListGoods});
        }

        [HttpPut("{id}")]
        public IActionResult Edit(string id, Goods goodsEdit)
        {
            try
            {
                // LinQ Object query
                var g = ListGoods.SingleOrDefault(g => g.id == Guid.Parse(id));
                if (g == null)
                {
                    return NotFound();
                }
                if (g.id != goodsEdit.id)
                {
                    return BadRequest();
                }
                g.name = goodsEdit.name;
                g.price = goodsEdit.price;
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        

        [HttpDelete("{id}")]
        public IActionResult Remove(string id)
        {
            try
            {
                var g = ListGoods.SingleOrDefault(g => g.id == Guid.Parse(id));
                if (g == null)
                {
                    return NotFound();
                }
                ListGoods.Remove(g);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
