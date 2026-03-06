using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemenykezelesOOP
{
	internal class BuildingEvents: Esemenyek
	{
		private int durability;
		private int occupancy;

		protected int Durability { get => durability; set => durability = value; }
		protected int Occupancy { get => occupancy; set => occupancy = value; }

		public BuildingEvents(string name, int duration, string effect, int durabilty, int occupancy) : base(name, duration, effect)
		{
			this.durability = durabilty;
			this.occupancy = occupancy;
		}

		public override string ToString()
		{
			return base.ToString() + $"{this.durability} {this.occupancy}";
		}
	}
}
