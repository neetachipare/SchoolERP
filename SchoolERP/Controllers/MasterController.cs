using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolERP.Controllers
{
    public class MasterController : Controller
    {
        // GET: Master
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SchoolMaster()
        {
            return View();

        }
        public ActionResult ViewSchoolMaster()
        {
            return View();
        }
    }
}