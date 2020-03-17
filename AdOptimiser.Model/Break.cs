using System;
using System.Collections.Generic;
using System.Text;

namespace AdOptimiser.Model
{
	public class Break
	{
		public int ID { get; set; }

		public BreakGroup BreakGroup { get; set; }

		public DemographicType DemogrphicType { get; set; }

		public int Rating { get; set; }
	}
}
