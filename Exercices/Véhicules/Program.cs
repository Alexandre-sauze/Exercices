using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    class Program
    {
        static void Main(string[] args)
        {
            Véhicule V1 = new Voiture("Porsche 911", Energies.Essence);
            Console.WriteLine(V1.Description);
            Véhicule V2 = new Moto("kawasaki NinjaR", Energies.Essence);
            Console.WriteLine(V2.Description);

            int res = V1.CompareTo(V2);
            if (res < 0)
                Console.WriteLine("{0} est plus économique que {1}", V1.Nom, V2.Nom);
            if (res > 0)
                Console.WriteLine("{0} est plus économique que {1}", V2.Nom, V1.Nom);
            if (res == 0)
                Console.WriteLine("{0} consomme autant que {1}", V1.Nom, V2.Nom);
        }
    }

    public enum Energies {Aucun, Essence, Gazole, GPL, Electrique}

}
