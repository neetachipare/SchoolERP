using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolERP.Areas.SuperAdmin.Controllers
{
    public class SideBarController : Controller
    {
        // GET: SuperAdmin/SideBar
        public ActionResult Index()
        {
            return View();
        }
    }
}