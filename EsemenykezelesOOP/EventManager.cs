using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsemenykezelesOOP
{
	internal class EventManager
	{

		// List of active Events
		private List<Event> activeEvents = new List<Event>();


		// Starting the Event 
		public void StartEvent(Event buildingEvent)
		{
			activeEvents.Add(buildingEvent);
			buildingEvent.ApplyEffect();
		}

		// Ending the Event
		public void EndEvent(Event buildingEvent)
		{
			activeEvents.Remove(buildingEvent);
			buildingEvent.RemoveEffect();
		}

	}
}
