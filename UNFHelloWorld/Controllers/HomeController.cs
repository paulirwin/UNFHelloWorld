﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UNFHelloWorld.Models;

namespace UNFHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        HelloDbContext _context = new HelloDbContext();

        public ActionResult Index()
        {
            var data = _context.HelloData.ToList();

            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}