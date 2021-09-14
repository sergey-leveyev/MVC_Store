using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Store.areas.admin.Controllers
{
    public class DashboardController : Controller
    {
        // GET: admin/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}