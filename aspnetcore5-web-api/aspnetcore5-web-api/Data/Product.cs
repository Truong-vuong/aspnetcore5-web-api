using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore5_web_api.Data
{
    public class Product
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        [MaxLength(100)]
        public string name { get; set; }
        public string description { get; set; }
        [Range(0, double.MaxValue)]
        public double price { get; set; }
        public double discount { get; set; }

        public int catagoryId { get; set; }
        [ForeignKey("catagoryId")]
        public Catagory CatagoryName { get; set; }
    }
}
