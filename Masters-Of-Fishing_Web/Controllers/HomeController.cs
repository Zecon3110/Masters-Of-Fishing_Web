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
		#region Main
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
		#endregion

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

		#region Catches
		public ActionResult CCaught(int id = 0)
		{
			Coast coast = context.CoastFactory.Get(id);
			return View(coast);
		}

		public ActionResult LCaught(int id = 0)
		{
			Lake lake = context.LakeFactory.Get(id);
			return View(lake);
		}

		public ActionResult OCaught(int id = 0)
		{
			Ocean ocean = context.OceanFactory.Get(id);
			return View(ocean);
		}

		public ActionResult RCaught(int id = 0)
		{
			River river = context.RiverFactory.Get(id);
			return View(river);
		}
		#endregion
	}
}