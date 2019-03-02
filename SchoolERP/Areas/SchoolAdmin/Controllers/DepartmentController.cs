using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolERP.Areas.SchoolAdmin.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: SchoolAdmin/Department
        public ActionResult Department()
        {
            return View();
        }

        public ActionResult Designation()
        {
            return View();
        }
    }
}