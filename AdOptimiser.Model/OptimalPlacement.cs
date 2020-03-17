using System;
using System.Collections.Generic;
using System.Text;

namespace AdOptimiser.Model
{
	public class OptimalPlacement
	{
		public string CommercialName { get; set; }

		public CommercialType CommercialType { get; set; }

		public DemographicType DemographicType { get; set; }

		public BreakGroup BreakGroup { get; set; }

		public int Rating { get; set; }
	}
}
