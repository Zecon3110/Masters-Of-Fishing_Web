using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Masters_Of_Fishing_Web.Models;

namespace Masters_Of_Fishing_Web.Factories
{
	public class DBContext
	{
		private static volatile DBContext INSTANCE;
		public static DBContext Instance
		{
			get
			{
				if (INSTANCE == null)
				{
					INSTANCE = new DBContext();
				}
				return INSTANCE;
			}
		}

		private AutoFactory<Coast> coastFactory;
		private AutoFactory<Lake> lakeFactory;
		private AutoFactory<Ocean> oceanFactory;
		private AutoFactory<River> riverFactory;

		public AutoFactory<Coast> CoastFactory
		{
			get
			{
				if (coastFactory == null)
				{
					coastFactory = new AutoFactory<Coast>();
				}
				return coastFactory;
			}
		}

		public AutoFactory<Lake> LakeFactory
		{
			get
			{
				if (lakeFactory == null)
				{
					lakeFactory = new AutoFactory<Lake>();
				}
				return lakeFactory;
			}
		}

		public AutoFactory<Ocean> OceanFactory
		{
			get
			{
				if (oceanFactory == null)
				{
					oceanFactory = new AutoFactory<Ocean>();
				}
				return oceanFactory;
			}
		}

		public AutoFactory<River> RiverFactory
		{
			get
			{
				if(riverFactory == null)
				{
					riverFactory = new AutoFactory<River>();
				}
				return riverFactory;
			}
		}
	}
}