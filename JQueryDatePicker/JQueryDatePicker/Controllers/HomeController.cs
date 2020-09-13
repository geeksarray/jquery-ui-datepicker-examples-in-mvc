using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JQueryDatePicker.Models;   

namespace JQueryDatePicker.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Customer cust = new Customer();
            cust.JoinDate = DateTime.Now.ToShortDateString();   
            return View(cust);
        }

        [HttpPost] 
        public ActionResult Index(Customer cust)
        {
            string joinDate = cust.JoinDate;
            return View();
        }

    }
}
