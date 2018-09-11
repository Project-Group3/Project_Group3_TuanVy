using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day8_Sercurity.Models;

namespace Day8_Sercurity.Controllers
{
    public class MasterDetailController : Controller
    {
        private ShopManagementEntities db = new ShopManagementEntities();
        // GET: MasterDetail
        public ActionResult Index()
        {
            MasterDetail MD = new MasterDetail();
            MD.Cus = GetCusModel();

            return View();
        }

        private Customer GetCusModel()
        {
            Customer CusModel = new Customer()
            {
                
            };
            return CusModel;
        }
    }
}