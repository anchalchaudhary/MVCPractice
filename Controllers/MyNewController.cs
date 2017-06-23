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
        public ActionResult Index()
        {
            MVCTutorialEntities db = new MVCTutorialEntities();
            List<tblBranch> list = db.tblBranches.ToList();
            ViewBag.BranchList = new SelectList(list,"ID","Branch");

            return View();
        }

        [HttpPost]
        public ActionResult Index(ViewNames model)
        {
            if (ModelState.IsValid == true)
            {
                
            }
            MVCTutorialEntities db = new MVCTutorialEntities();
            List<tblBranch> list = db.tblBranches.ToList();
            ViewBag.BranchList = new SelectList(list, "ID", "Branch");
            return View(model);
        }
        //public ActionResult Save(ViewNames model)
        //{
        //    MVCTutorialEntities db = new MVCTutorialEntities();
        //    try
        //    {
        //        tblName objtblName = new tblName();
        //        objtblName.Name = model.Name;
        //        objtblName.Branch = model.ID;

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