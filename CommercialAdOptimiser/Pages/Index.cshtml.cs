using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AdOptimiser.Data;
using AdOptimiser.Model;

namespace CommercialAdOptimiser.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ICommercialAdOptimiser commercialAdOptimiser;

		public IEnumerable<Commercial> Commercials { get; set; }

		public IEnumerable<Break> Breaks { get; set; }

		public IEnumerable<OptimalPlacement> OptimalPlacements { get; set; }
		public List<OptimalPlacement> optimalPlacements { get; private set; }

		public List<CommercialSum> sumQuery { get; set; }

		public IndexModel(ICommercialAdOptimiser commercialOptimiser)
		{
			this.commercialAdOptimiser = commercialOptimiser;
		}
		public void OnGet()
		{
			optimalPlacements = new List<OptimalPlacement>();
			List<Commercial> commercials = commercialAdOptimiser.GetAllCommercialsList().ToList();

			var BreakGroupsPlanned = commercialAdOptimiser.GetAllBreakLists().
						  OrderByDescending(c => c.Rating).
						  OrderBy(c => c.BreakGroup).
						  GroupBy(b => b.BreakGroup).ToList();

			CommercialType comType = CommercialType.Default;

			

			
			foreach (var breakGroup in BreakGroupsPlanned)
			{
				
				foreach (var item in breakGroup)
				{

					var demoType = item.DemogrphicType;
					Commercial plaementFinder = null;

					if (breakGroup.Key.ToString() == "BreakGroup2")
					{
						plaementFinder = commercials
										 .Where(x => x.Type != comType && x.Type != CommercialType.Finance)
										 .FirstOrDefault(x => x.DemographicClass == demoType);
						comType = plaementFinder.Type;
					}
					else
					{
						plaementFinder = commercials
										 .Where(x => x.Type != comType)
										 .FirstOrDefault(x => x.DemographicClass == demoType);
						comType = plaementFinder.Type;
					}



					OptimalPlacement opt = new OptimalPlacement
					{
						CommercialName = plaementFinder.Name,
						CommercialType = plaementFinder.Type,
						DemographicType = plaementFinder.DemographicClass,
						BreakGroup = item.BreakGroup,
						Rating = item.Rating
					};
					
					optimalPlacements.Add(opt);
					commercials.Remove(plaementFinder);
				}

				
			}

			sumQuery = optimalPlacements.GroupBy(x => x.BreakGroup)
				.Select( CS => new CommercialSum
				{
					BreakGroupName= CS.First().BreakGroup.ToString(),
					SumOfBreakGroupViews = CS.Sum(cs => cs.Rating)
				}).ToList();
		}
	}
}

