using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace EsemenykezelesOOP
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
			EventManager eventManager = new EventManager();
            NPCEvents newNPC = new NPCEvents("Tamás",31,100,"Islam",80,true);
            eventManager.StartEvent(newNPC);

           
		}

    }
}
