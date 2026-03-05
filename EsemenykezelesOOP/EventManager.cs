using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EsemenykezelesOOP
{
    internal class EventManager
    {
        private List<GameEvent> activeEvents = new List<GameEvent>();


        // Starting the event
        public void StartEvent(GameEvent newEvent)
        {
            activeEvents.Add(newEvent);
            newEvent.ApplyEffect();
        }

        // Time
        public void Tick()
        {
            // backward removing
            for (int i = activeEvents.Count; i >= 0; i--)
            {
                activeEvents[i].Duration--;

                if (activeEvents[i].Duration <= 0)
                {
                    // Ending of the event
                    activeEvents[i].RemoveEffect();
                    activeEvents.RemoveAt(i);
                }
            }
        }
        public void ActiveEvents()
        {
            Console.WriteLine("\n--- Current Status ---");
            if (activeEvents.Count == 0)
            {
                Console.WriteLine("Everything is fine.");
            }
            foreach (var i in activeEvents)
            {
                Console.WriteLine($"- {i.Name} {i.Duration} tick left. -");
            }
        }
    }
}
