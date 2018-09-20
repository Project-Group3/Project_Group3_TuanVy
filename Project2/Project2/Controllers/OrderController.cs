using Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    public class OrderController : Controller
    {
        MyDatabaseEntities db = new MyDatabaseEntities();
        // GET: Order
        public ActionResult Index()
        {
            List<Customer> OrderAndCustomerList = db.Customers.ToList();
            return View(OrderAndCustomerList);

        }
    }
}