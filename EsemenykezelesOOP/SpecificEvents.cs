using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemenykezelesOOP
{
	internal class SpecificEvents
	{
        // Spamming Da Events -_-

        public class PowerOutage : GameEvent
        {

            // Constructor 
            public PowerOutage(int duration) : base("PowerOutage", duration) { }
          
            // Must have methods
            public override void ApplyEffect()
            {
                Console.WriteLine("$The PowerOutage has started!");
            }
            public override void RemoveEffect()
            {
                Console.WriteLine("$The PowerOutage has ended!");
            }
		}
        public class EconomicCrisis : GameEvent
        {

            // Constructor 
            public EconomicCrisis(int duration) : base("EconomicCrisis", duration) { }

            // Must have methods
            public override void ApplyEffect()
            {
                Console.WriteLine("$The EconomicCrisis has started!");
            }
            public override void RemoveEffect()
            {
                Console.WriteLine("$The EconomicCrisis has ended!");
            }
        }

    }
}
