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
            MVCTutorialEntities db = new MVCTutorialEntities();

            List<tblName> nameList = db.tblNames.ToList();

            List<ViewNames> objVMList = nameList.Select(x => new ViewNames
            {
                Name = x.Name,
                ID = x.ID,
            }).ToList();

            return View(objVMList);
        }

        public ActionResult StudentDetail(int ID)
        {
            MVCTutorialEntities db = new MVCTutorialEntities();
            tblName name = db.tblNames.SingleOrDefault(x => x.ID == ID);
            ViewNames objVM = new ViewNames();
            objVM.ID = name.ID;
            objVM.Name = name.Name;
            objVM.Branch = name.Branch;
            objVM.BranchName = name.tblBranch.Branch;

            return View(objVM);
        }

        public ActionResult SecondPage()
        {
            return View();
        }
    }
}