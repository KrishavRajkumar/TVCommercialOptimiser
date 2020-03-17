using System;
using System.Collections.Generic;
using System.Text;
using AdOptimiser.Model;

namespace AdOptimiser.Data
{
	public class InMemoryCommercialOptimiser : ICommercialAdOptimiser
	{

		readonly IEnumerable<Commercial> commercialList;

		readonly IEnumerable<Break> BreakGroupList;



		public InMemoryCommercialOptimiser()
		{
			commercialList =
			   new List<Commercial>
			   {
					new Commercial { ID =1, Name ="Commercial1", Type =CommercialType.Automative, DemographicClass=DemographicType.W },
					new Commercial { ID =2,Name ="Commercial2", Type =CommercialType.Travel, DemographicClass=DemographicType.M },
					new Commercial { ID =3,Name ="Commercial3", Type =CommercialType.Travel, DemographicClass=DemographicType.T },
					new Commercial { ID =4,Name ="Commercial4", Type =CommercialType.Automative, DemographicClass=DemographicType.M },
					new Commercial { ID =5,Name ="Commercial5", Type =CommercialType.Automative, DemographicClass=DemographicType.M },
					new Commercial { ID =6,Name ="Commercial6", Type =CommercialType.Finance, DemographicClass=DemographicType.W },
					new Commercial { ID =7,Name ="Commercial7", Type =CommercialType.Finance, DemographicClass=DemographicType.M },
					new Commercial { ID =8,Name ="Commercial8", Type =CommercialType.Automative, DemographicClass=DemographicType.T },
					new Commercial { ID =9,Name ="Commercial9", Type =CommercialType.Travel, DemographicClass=DemographicType.W },
					new Commercial { ID =10,Name ="Commercial10", Type =CommercialType.Finance, DemographicClass=DemographicType.T }
			   };

			BreakGroupList = new List<Break>
			{
				new Break{ ID=1, BreakGroup = BreakGroup.Break1, DemogrphicType= DemographicType.W, Rating=80},
				new Break{ ID=2, BreakGroup = BreakGroup.Break1, DemogrphicType= DemographicType.M, Rating=100},
				new Break{ ID=3, BreakGroup = BreakGroup.Break1, DemogrphicType= DemographicType.T, Rating=250},
				new Break{ ID=4, BreakGroup = BreakGroup.Break2, DemogrphicType= DemographicType.W, Rating=50},
				new Break{ ID=5, BreakGroup = BreakGroup.Break2, DemogrphicType= DemographicType.M, Rating=120},
				new Break{ ID=6, BreakGroup = BreakGroup.Break2, DemogrphicType= DemographicType.T, Rating=200},
				new Break{ ID=7, BreakGroup = BreakGroup.Break3, DemogrphicType= DemographicType.W, Rating=350},
				new Break{ ID=8, BreakGroup = BreakGroup.Break3, DemogrphicType= DemographicType.M, Rating=150},
				new Break{ ID=9, BreakGroup = BreakGroup.Break3, DemogrphicType= DemographicType.T, Rating=500}
			};
		}

		public IEnumerable<Break> GetAllBreakLists()
		{
			return BreakGroupList;
		}

		public IEnumerable<Commercial> GetAllCommercialsList()
		{
			return commercialList;
		}
	}
}
