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
			Console.WriteLine("Applied effect: Death");
		}

        public override void RemoveEffect()
        {
            Console.WriteLine("Removed effect.");
        }


		public void Deaths()
		{
			if (this.health == 0)
			{
				status = false;
				Console.WriteLine($"{this.name} Died!");
			}


		}

    }
}
