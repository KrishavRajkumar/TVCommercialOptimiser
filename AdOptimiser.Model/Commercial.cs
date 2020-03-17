using System;
using System.Collections.Generic;
using System.Text;

namespace AdOptimiser.Model
{
	public class Commercial
	{
		public int ID { get; set; }
		public string Name { get; set; }

		public CommercialType Type { get; set; }

		public DemographicType DemographicClass { get; set; }
	}
}
