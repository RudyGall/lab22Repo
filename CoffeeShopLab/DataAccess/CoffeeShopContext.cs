using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoffeeShopLab.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CoffeeShopLab.DataAccess
{
    public class CoffeeShopContext : DbContext
    {

        public CoffeeShopContext() : base("CoffeeShopContext")
        {
            
        }
        public DbSet<RegisterUser> RegisterUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}