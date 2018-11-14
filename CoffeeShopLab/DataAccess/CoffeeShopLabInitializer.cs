using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CoffeeShopLab.Models;

namespace CoffeeShopLab.DataAccess
{
    public class CoffeeShopLabInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<CoffeeShopContext>
    {
        protected override void Seed(CoffeeShopContext context)
        {
            var user = new List<RegisterUser>
            {
            new RegisterUser{ FirstName = "Rudy", LastName = "Gall", Age = "20", Date = DateTime.Now, Email = "rudyegall@gmail.com", PassWord = "asdf", PhoneNumber = "2488900136", SSN = "666-66-6666" },
            new RegisterUser { FirstName = "John", LastName = "Weathers", Age = "34", Date = DateTime.Now, Email = "johnsongreen@gmail.com", PassWord = "asdfg", PhoneNumber = "2488900136", SSN = "666-66-6666" }
        };
            user.ForEach(s => context.RegisterUsers.Add(s));
            context.SaveChanges();
        }
    }
}