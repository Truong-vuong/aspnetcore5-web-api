using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcore5_web_api.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        #endregion

    }
}
