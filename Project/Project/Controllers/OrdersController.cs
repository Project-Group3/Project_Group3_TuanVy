using Project.Models;
using Rotativa;
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
       
        public ActionResult Index(string searchString)
        {
            var OrderAndCustomerList = from m in db.Customers select m;
            if (!String.IsNullOrEmpty(searchString))
            List<Customer> OrderAndCustomerList = db.Customers.ToList();
            return View(OrderAndCustomerList);
        }
        public ActionResult SaveOrder(string name, String address, Order[] order)
        {
            string result = "Error! Order Is Not Complete!";
            if (name != null && address != null && order != null)
            {
                OrderAndCustomerList = OrderAndCustomerList.Where(s => s.Name.Contains(searchString));
            }

            return View(OrderAndCustomerList);
        }

    }
}
