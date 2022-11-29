using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreOnline.Controllers
{
    public class HomeController : Controller
    {
        private AdminDbContext db = new AdminDbContext();
        // GET: Index
        public ActionResult Index()
        {
            return View(db.Admins.ToList());
        }


    }
}