using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace EsemenykezelesOOP
{
    internal class MainProgram
    {
        static void Main(string[] args)
        { 
            EventManager eventManager = new EventManager();

            // Creating events
            eventManager.StartEvent(new SpecificEvents.PowerOutage());
            eventManager.StartEvent(new SpecificEvents.EconomicCrisis());

            // Time passing
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\n-- WEEK {i} --");
                eventManager.Tick();
                eventManager.ActiveEvents();
            }

            Console.WriteLine("Finished... Press any key to exit.");
            Console.ReadKey();
        }

    }
}
