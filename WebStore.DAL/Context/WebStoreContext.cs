using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.DAL.Context
{
    public class WebStoreContext : DbContext
    {
        public WebStoreContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
