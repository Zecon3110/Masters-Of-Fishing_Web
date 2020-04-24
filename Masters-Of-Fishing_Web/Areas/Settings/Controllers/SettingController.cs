using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Masters_Of_Fishing_Web.Areas.Settings.Controllers
{
    public class SettingController : Controller
    {
        // GET: Settings/Setting
        public ActionResult River()
        {
            return View();
        }

		public ActionResult EditFish()
		{
			return View();
		}
    }
}