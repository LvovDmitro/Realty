using Microsoft.EntityFrameworkCore;
using Realty.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Realty.Data
{
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {

        }

        public DbSet<Flat> Flat { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<RealtyFlatItem> RealtyFlatItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


    }
}
