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
            #region viewbag, viewdata, tempdata
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
            #endregion
            MVCTutorialEntities db = new MVCTutorialEntities();

            #region single table
            //tblName name = db.tblNames.SingleOrDefault(x => x.ID == 1);
            //ViewNames objVM = new ViewNames();
            //objVM.ID = name.ID;
            //objVM.Name = name.Name;
            //objVM.Branch = name.Branch;
            //return View(objVM);
            #endregion

            List<tblName> nameList = db.tblNames.ToList();
            ViewNames objVM = new ViewNames();
            List<ViewNames> objVMList = nameList.Select(x => new ViewNames
            {
                Name = x.Name,
                ID = x.ID,
                Branch = x.Branch,
                BranchName = x.tblBranch.Branch
            }).ToList();

            return View(objVMList);
        }

        public ActionResult SecondPage()
        {
            return View();
        }
    }
}