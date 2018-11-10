using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShopLab.Models;

namespace CoffeeShopLab.Controllers
{
    public class CoffeeShopController : Controller
    {
        // GET: CoffeeShop
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {



            return View(); 
        }



        [HttpPost]
        public ActionResult AddUser(RegisterUser model)
        {



            return View(model); 


        }
    }
}