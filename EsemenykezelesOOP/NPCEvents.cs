using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemenykezelesOOP
{
	internal class NPCEvents : Event
	{
		private int health;
		private string religon;
		private int happiness; // On a scale of 0-100
		private bool status; // Dead or Not



		// Constructor
		public NPCEvents(string name, int duration, int health, string religon, int happiness, bool status) : base(name, duration)
        {
			this.health = health;
			this.religon = religon;
			this.happiness = happiness;
			this.status = status;
        }

        public override void ApplyEffect()
		{
			Deaths();
		}

        public override void RemoveEffect()
        {
            Console.WriteLine("Removed effect.");
        }


		public void Deaths()
		{
			if (this.health == 0 && this.happiness <= 10)
			{
				status = false;
				Console.WriteLine($"{this.name} Died!");
			}

		}

		public override string ToString()
		{
			return base.ToString() + $" {this.health} {this.religon} {this.happiness} {this.status}";
		}

    }
}
