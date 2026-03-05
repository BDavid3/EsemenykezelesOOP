using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemenykezelesOOP
{
	internal class Adattar
	{
		private List<SpecificEvents> randomEvents; // random
		private List<SpecificEvents> annualEvents; // ünnep 

		public Adattar()
		{
			randomEvents = new List<SpecificEvents>
			{
				new SpecificEvents("Emigration", 60),
				new SpecificEvents("Inflation", 30),
				new SpecificEvents("Economic Change", 45),
				new SpecificEvents("Political Change", 20),
				new SpecificEvents("Natural Disaster", 52)
			};
			annualEvents = new List<SpecificEvents>
			{
				new SpecificEvents("Christmas", 120),
				new SpecificEvents("New Year", 90),
				new SpecificEvents("Hallowen", 60),
				new SpecificEvents("Valentines Day", 30),
				new SpecificEvents("National Days", 45)
			};
		}

		internal List<SpecificEvents> RandomEvents { get => randomEvents; set => randomEvents = value; }
		internal List<SpecificEvents> AnnualEvents { get => annualEvents; set => annualEvents = value; }


	}
}
