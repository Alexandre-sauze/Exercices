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
            Véhicule V1 = new Voiture("Porsche", Energies.Essence);
        }
    }

    public enum Energies {Aucun, Essence, Gazole, GPL, Electrique}

}
