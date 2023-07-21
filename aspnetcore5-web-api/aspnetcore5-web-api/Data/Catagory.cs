using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore5_web_api.Data
{
    public class Catagory
    {
        public int catagoryId { get; set; }
        [Required]
        public string catagoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
