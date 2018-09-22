using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        MyDatabaseEntities db = new MyDatabaseEntities();
        // GET: Order
        public ActionResult Index(string searchString)
        {
            var OrderAndCustomerList = from m in db.Customers select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                OrderAndCustomerList = OrderAndCustomerList.Where(s => s.Name.Contains(searchString));
            }

            return View(OrderAndCustomerList);
        }

    }
}