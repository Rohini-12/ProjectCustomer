﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevelopeXpertize.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Online GreenMart allows you to walk away from the drudgery of grocery shopping and welcome an easy relaxed way of browsing and shopping for groceries.Discover new products and shop for all your food and grocery needs from the comfort of your home or office.No more getting stuck in traffic jams, paying for parking, standing in long queues and carrying heavy bags – get everything you need, when you need, right at your doorstep.Food shopping online is now easy as every product on your monthly shopping list, is now available online at bigbasket.com, India’s best online grocery store.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Details.";

            return View();
        }

        public ActionResult SignIn()
        {
            return View();
        }

       

        public ActionResult Decide()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
    }
}