using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace SB.Product.Api.Database
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Models.Product> Products { get; set; }
    }
}
