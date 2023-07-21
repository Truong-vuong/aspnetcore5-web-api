using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore5_web_api.Models
{
    public class GoodsVM
    {
        public string name { get; set; }
        public double price { get; set; }
    }

    public class Goods : GoodsVM
    {
        public Guid id { get; set; }
    }
}
