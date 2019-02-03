using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolERP.Areas.SuperAdmin.Controllers
{
    public class InstituteController : Controller
    {
        // GET: SuperAdmin/Institute
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InstituteRegistration()
        {
            return View();
        }
    }
}