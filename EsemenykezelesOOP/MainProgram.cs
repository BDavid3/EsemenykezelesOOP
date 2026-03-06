using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace EsemenykezelesOOP
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
			BuildingEvents b1 = new BuildingEvents("Áramszünet", 10, "ASDFGJ", 100, 50);
			Console.WriteLine(b1);
        }

    }
}
