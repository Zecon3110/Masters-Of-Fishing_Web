using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Masters_Of_Fishing_Web.Models;
using Masters_Of_Fishing_Web.Factories;

namespace Masters_Of_Fishing_Web.Controllers
{
    public class HomeController : Controller
    {
		DBContext context = new DBContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Hub()
		{
			return View();
		}

		public ActionResult Settings()
		{
			return View();
		}

		public ActionResult End()
		{
			return View();
		}

		#region Places
		public ActionResult River()
		{
			return View();
		}

		public ActionResult Lake()
		{
			return View();
		}

		public ActionResult Coast()
		{
			return View();
		}

		public ActionResult Ocean()
		{
			return View();
		}
		#endregion

		public ActionResult Caught()
		{
			return View();
		}
	}
}