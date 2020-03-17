using AdOptimiser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdOptimiser.Data
{
	public interface ICommercialAdOptimiser
	{
		IEnumerable<Commercial> GetAllCommercialsList();

		IEnumerable<Break> GetAllBreakLists();
	}
}
