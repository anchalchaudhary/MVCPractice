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
            //List<Names> namesList = new List<Names>();
            //Names name = new Names();

            //namesList.Add(new Names { ID = 1, Name = "Anchal", Branch = "IT" });
                        
            //ViewBag.NamesList = namesList;
            //ViewData["NamesList"] = namesList;

            //ViewBag.NameVB = "Anchal";
            //ViewData["NameVD"] = "Salvee";
            //TempData["NameTD"] = "Ayushi";

            //TempData.Keep();

            //return View(namesList);

            MVCTutorialEntities db = new MVCTutorialEntities();
            tblName name = db.tblNames.SingleOrDefault(x => x.ID == 1);

            ViewNames objVM = new ViewNames();
            objVM.ID = name.ID;
            objVM.Name = name.Name;
            objVM.Branch = name.Branch;

            return View(objVM);
        }

        public ActionResult SecondPage()
        {
            return View();
        }
    }
}