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
            Véhicule v2 = new Moto("kawasaki NinjaR", Energies.Essence);
            Console.WriteLine(v2.Description);
        }
    }

    public enum Energies {Aucun, Essence, Gazole, GPL, Electrique}

}
