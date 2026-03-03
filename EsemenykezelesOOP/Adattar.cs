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
				new Event("Kivandorlas", 60),
				new Event("Inflacio", 30),
				new Event("Gazdasagi valsag", 45),
				new Event("Politikai valtozas", 20),
				new Event("Termeszeti katasztrofa", 50)
			};
			annualEvents = new List<Event>
			{
				new Event("Karacsony", 120),
				new Event("Uj ev", 90),
				new Event("Hallowen", 60),
				new Event("Valentin nap", 30),
				new Event("Nemzeti unnep", 45)
			};
		}

		internal List<Event> RandomEvents { get => randomEvents; set => randomEvents = value; }
		internal List<Event> AnnualEvents { get => annualEvents; set => annualEvents = value; }


	}
}
