using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace EsemenykezelesOOP
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
			EventManager eventManager = new EventManager();
            eventManager.StartEvent(new BuildingEvents("teszname",1,100,50));

		}

    }
}
