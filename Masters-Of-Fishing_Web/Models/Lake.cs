using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Masters_Of_Fishing_Web.Models
{
	public class Lake
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public decimal Weight { get; set; }
		public decimal Length { get; set; }
	}
}