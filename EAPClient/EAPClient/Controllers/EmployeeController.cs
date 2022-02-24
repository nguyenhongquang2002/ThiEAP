using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EAPClient.Controllers
{

    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ServiceClient.Service1Client service1Client = new ServiceClient.Service1Client();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}