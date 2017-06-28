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

            List<ViewNames> presentNames = db.tblNames.Where(x => x.IsDeleted == 0).Select(x => new ViewNames { Name = x.Name, BranchID = x.BranchID, BranchName = x.tblBranch.Branch, ID = x.ID }).ToList();

            ViewBag.PresentList = presentNames;
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
        public JsonResult Delete(int ID)
        {
            bool result = false;
            tblName objtblName = db.tblNames.SingleOrDefault(x=>x.IsDeleted==0 &&  x.ID==ID );
            if(objtblName!=null)
            {
                objtblName.IsDeleted = 1;
                db.SaveChanges();
                result = true;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}