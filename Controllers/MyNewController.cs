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
    }
}