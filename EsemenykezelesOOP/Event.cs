using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemenykezelesOOP
{
	// BLUEPRINT
	internal class Event
	{
		private string name;
		private int duration;
		

		public Event(string name, int duration)
		{
			this.name = name;
			this.duration = duration;
		}

		public string Name { get => name; set => name = value; }
		public int Duration { get => duration; set => duration = value; }

		public override string ToString()
		{
			return $"Event: {name}, Duration: {duration}";
		}
	}
}
