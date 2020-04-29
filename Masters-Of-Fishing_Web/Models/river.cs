using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Masters_Of_Fishing_Web.Models
{
	public class River
	{
		public int ID { get; set; }
		public string Name { get; set; }
		[AllowHtml]
		public decimal Weight { get; set; }
		public decimal Length { get; set; }
	}
}