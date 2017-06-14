using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //ViewBag.Name = "Anchal";
            //List<string> list = new List<string>();
            //list.Add("Anchal");
   
            //ViewBag.NameList = list;

            List<Names> namesList = new List<Names>();
            Names name = new Names();

            namesList.Add(new Names { ID = 1, Name = "Anchal", Branch = "IT" });
            namesList.Add(new Names { ID = 2, Name = "Kanika", Branch = "EC" });
            namesList.Add(new Names { ID = 3, Name = "Simran", Branch = "IT" });
            namesList.Add(new Names { ID = 4, Name = "Ayush", Branch = "IT" });
            namesList.Add(new Names { ID = 5, Name = "Nakshtra", Branch = "IT" });

            ViewBag.NamesList = namesList;
            ViewData["NamesList"] = namesList;

            ViewBag.NameVB = "Anchal";
            ViewData["NameVD"] = "Salvee";
            TempData["NameTD"] = "Ayushi";

            TempData.Keep();
            
            return View(namesList);
        }

        public ActionResult SecondPage()
        {
            return View();
        }
    }
}