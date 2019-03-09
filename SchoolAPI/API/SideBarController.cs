using SchoolAPI.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolAPI.API
{
    public class SideBarController : ApiController
    {
        [HttpPost]
        public object GetSiteMenu()
        {
            MenuBussiness obj = new MenuBussiness();
            return obj.GetSiteMenu();
        }
    }
}
