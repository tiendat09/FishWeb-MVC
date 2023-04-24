using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarkShop.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        private QLBanCaCanhDataContext db = new QLBanCaCanhDataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TotalProduct()
        {

        }
    }
}