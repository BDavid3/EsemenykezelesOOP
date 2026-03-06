using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemenykezelesOOP
{
	internal class Esemenyek
	{
		private string name;
		private int duration;
		private string effect;

		public string Name { get => name; set => name = value; }
		protected int Duration { get => duration; set => duration = value; }
		protected string Effect { get => effect; set => effect = value; }

		public Esemenyek(string name, int duration, string effect)
		{
			this.name = name;
			this.duration = duration;
			this.effect = effect;
		}

		public override string ToString()
		{
			return $"{this.name} {this.duration} {this.effect}";
		}
	}
}
