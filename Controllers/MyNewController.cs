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
            #region For Saving Data
            tblName objtblName = new tblName();
            objtblName.Name = model.Name;
            objtblName.BranchID = model.BranchID;

            db.tblNames.Add(objtblName);

            db.SaveChanges();
            #endregion
            int latestNameID = objtblName.ID;
            return View(model);
        }
        //public ActionResult Save(ViewNames model)
        //{
        //    MVCTutorialEntities db = new MVCTutorialEntities();
        //    try
        //    {
        //        tblName objtblName = new tblName();
        //        objtblName.Name = model.Name;
        //        objtblName.BranchID = model.BranchID;

        //        db.tblNames.Add(objtblName);

        //        db.SaveChanges();

        //        int latestNameID = objtblName.ID;
        //    }
        //    catch(Exception ex)            
        //    {

        //    }
        //    return RedirectToAction("Index");
        //}
    }
}