using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class MyNewController : Controller
    {
        // GET: MyNew
        MVCTutorialEntities db = new MVCTutorialEntities();

        public ActionResult Index()
        {
            List<tblBranch> list = db.tblBranches.ToList();
            ViewBag.BranchList = new SelectList(list, "BranchID", "Branch");

            return View();
        }

        [HttpPost]
        public ActionResult Index(ViewNames model)
        {
            List<tblBranch> list = db.tblBranches.ToList();
            ViewBag.BranchList = new SelectList(list, "BranchID", "Branch");

            if (ModelState.IsValid)
            {
                tblName objtblName = new tblName();

                #region For Saving Data
                objtblName.Name = model.Name;
                objtblName.BranchID = model.BranchID;

                db.tblNames.Add(objtblName);

                db.SaveChanges();
                #endregion

                int latestNameID = objtblName.ID;

                tblCity objtblCity = new tblCity();
                objtblCity.City = model.City;
                objtblCity.ID = latestNameID;

                db.tblCities.Add(objtblCity);
                db.SaveChanges();
            }
            return View(model);
        }
    }
}