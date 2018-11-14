using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShopLab.Models;
using System.Web.Mvc.Html;
using CoffeeShopLab.DataAccess;
namespace CoffeeShopLab.Controllers
{
    public class CoffeeShopController : Controller
    {
        private CoffeeShopContext db = new CoffeeShopContext();
        // GET: CoffeeShop
        public ActionResult Index()
        {
            var bleh = db.RegisterUsers.ToList();
          
            return View();
        }

        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddUser(RegisterUser newUser)
        {
            if (ModelState.IsValid)
            {
                db.RegisterUsers.Add(newUser);
                db.SaveChanges();


                ViewBag.ConfMessage = "Welcome " + newUser.FirstName;
                return View();
            }
            else
            {
                return View("Error");
            }
        }
    }
}