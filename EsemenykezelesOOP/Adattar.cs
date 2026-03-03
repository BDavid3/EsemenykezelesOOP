using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemenykezelesOOP
{
	internal class Adattar
	{
		private List<Event> randomEvents; // random
		private List<Event> annualEvents; // ünnep 

		public Adattar()
		{
			randomEvents = new List<Event>
			{
				new Event("Emigration", 60),
				new Event("Inflation", 30),
				new Event("Economic Change", 45),
				new Event("Political Change", 20),
				new Event("Natural Disaster", 52)
			};
			annualEvents = new List<Event>
			{
				new Event("Christmas", 120),
				new Event("New Year", 90),
				new Event("Hallowen", 60),
				new Event("Valentines Day", 30),
				new Event("National Days", 45)
			};
		}

		internal List<Event> RandomEvents { get => randomEvents; set => randomEvents = value; }
		internal List<Event> AnnualEvents { get => annualEvents; set => annualEvents = value; }


	}
}
