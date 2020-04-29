using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Masters_Of_Fishing_Web.Models;
using Masters_Of_Fishing_Web.Factories;

namespace Masters_Of_Fishing_Web.Areas.Settings.Controllers
{
    public class SettingController : Controller
    {
		DBContext context = new DBContext();

		// GET: Settings/Setting
		#region Coast
		public ActionResult Coast()
		{
			return View(context.CoastFactory.GetAll());
		}

		public ActionResult AddCoastFish()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddCoastFish(Coast coast)
		{
			context.CoastFactory.Insert(coast);
			return RedirectToAction("Coast");
		}

		public ActionResult EditCoastFish(int id = 0)
		{
			Coast coast = context.CoastFactory.Get(id);
			return View(coast);
		}

		[HttpPost]
		public ActionResult EditRiverFish(Coast coast)
		{
			context.CoastFactory.Update(coast);
			return RedirectToAction("Coast");
		}

		public ActionResult DeleteCoastFish(int id = 0)
		{
			Coast coast = context.CoastFactory.Get(id);
			context.CoastFactory.Delete(id);
			return RedirectToAction("Coast");
		}
		#endregion

		#region Lake
		public ActionResult Lake()
		{
			return View(context.LakeFactory.GetAll());
		}

		public ActionResult AddLakeFish()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddLakeFish(Lake lake)
		{
			context.LakeFactory.Insert(lake);
			return RedirectToAction("Lake");
		}

		public ActionResult EditLakeFish(int id = 0)
		{
			Lake lake = context.LakeFactory.Get(id);
			return View(lake);
		}

		[HttpPost]
		public ActionResult EditLakeFish(Lake lake)
		{
			context.LakeFactory.Update(lake);
			return RedirectToAction("Lake");
		}

		public ActionResult DeleteLakeFish(int id = 0)
		{
			Lake lake = context.LakeFactory.Get(id);
			context.LakeFactory.Delete(id);
			return RedirectToAction("Lake");
		}
		#endregion

		#region Ocean
		public ActionResult Ocean()
		{
			return View(context.OceanFactory.GetAll());
		}

		public ActionResult AddOceanFish()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddOceanFish(Ocean ocean)
		{
			context.OceanFactory.Insert(ocean);
			return RedirectToAction("Ocean");
		}

		public ActionResult EditOceanFish(int id = 0)
		{
			Ocean ocean = context.OceanFactory.Get(id);
			return View(ocean);
		}

		[HttpPost]
		public ActionResult EditOceanFish(Ocean ocean)
		{
			context.OceanFactory.Update(ocean);
			return RedirectToAction("Ocean");
		}

		public ActionResult DeleteOceanFish(int id = 0)
		{
			Ocean ocean = context.OceanFactory.Get(id);
			context.OceanFactory.Delete(id);
			return RedirectToAction("Ocean");
		}
		#endregion

		#region River
		public ActionResult River()
        {
            return View(context.RiverFactory.GetAll());
        }

		public ActionResult AddRiverFish()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddRiverFish(River river)
		{
			context.RiverFactory.Insert(river);
			return RedirectToAction("River");
		}

		public ActionResult EditRiverFish(int id = 0)
		{
			River river = context.RiverFactory.Get(id);
			return View(river);
		}

		[HttpPost]
		public ActionResult EditRiverFish(River river)
		{
			TempData["SYS_MSG"] = "Changes to this fish has been updated";
			context.RiverFactory.Update(river);
			return RedirectToAction("River");
		}

		public ActionResult DeleteRiverFish(int id = 0)
		{
			River river = context.RiverFactory.Get(id);
			context.RiverFactory.Delete(id);
			return RedirectToAction("River");
		}
		#endregion
	}
}