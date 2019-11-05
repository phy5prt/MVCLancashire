using MVCLancashire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLancashire.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ViewCustomer() {
            Customer customer = new Customer();
            //guid is random unique number computer generates useful in dbs
            customer.Id = Guid.NewGuid().ToString();
            customer.Name = "Fred";
            customer.Telephone = "01879843";

            return View(customer);

        }

        public ActionResult AddCustomer() {
            return View();

        }
    }
}