using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SchoolAPI.Param;
using SchoolAPI.ResultModel;
using SchoolAPI.BusinessLayer;



namespace SchoolAPI.API
{
    public class MenuSubMenuController : ApiController
    {
        
       [HttpPost]
        public object GetMenuSubMenu()

        {
            MenuBussiness obj = new MenuBussiness();

            return obj.Getdata();
        }
        [HttpPost]
        public object GetMenuSubMenuDemo()

        {
            MenuBussiness obj = new MenuBussiness();

            return obj.GetMenu();
        }
        [HttpPost]
        public object SaveMenuSubMenu(MenuSubMenuParam objmenu)
        {
            MenuBussiness obj = new MenuBussiness();

            return obj.SaveMenu(objmenu);
        }
        [HttpPost]
        public object GetRoleData()
        {
            MenuBussiness obj = new MenuBussiness();
            return obj.GetRole();

        }

        [HttpPost]
        public object GetSingleMenuSubMenu(MenuSubMenuParam objmenu)
        {
            MenuBussiness obj = new MenuBussiness();
           return obj.GetSingleSubMenu(objmenu);

        }

        [HttpPost]
        public object GetDuplicateRole(MenuSubMenuParam objmenu)
        {
            MenuBussiness obj = new MenuBussiness();
            return obj.GetDuplicateMenu(objmenu);

        }
        public object UpdateMenuSubMenu(MenuSubMenuParam objmenu)
        {
            MenuBussiness obj = new MenuBussiness();
            return obj.UpdateMenuSubMenu(objmenu);

        }

    }
}