using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace EsemenykezelesOOP
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
			EventManager eventManager = new EventManager();
            Database database = new Database();
            NPCEvents newNPC = new NPCEvents("Tamás",31,0,"Islam",80,true);
            database.NPCAdd(newNPC);
            database.Kiiratas();
           
           
		}

    }
}
