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
            //Véhicule V1 = new Voiture("Porsche 911", Energies.Essence);
            //Console.WriteLine(V1.Description);
            //Véhicule V2 = new Moto("kawasaki NinjaR", Energies.Essence);
            //Console.WriteLine(V2.Description);


            //int res = V1.CompareTo(V2);
            //if (res < 0)
            //    Console.WriteLine("{0} est plus économique que {1}", V1.Nom, V2.Nom);
            //if (res > 0)
            //    Console.WriteLine("{0} est plus économique que {1}", V2.Nom, V1.Nom);
            //if (res == 0)
            //    Console.WriteLine("{0} consomme autant que {1}", V1.Nom, V2.Nom);

            Véhicule V3 = new Voiture("MeganeRS", 19000);
            Véhicule V4 = new Moto("Intruder", 13000);
            Véhicule V5 = new Voiture("Ferrari Enzo", 380000);
            Véhicule V6 = new Moto("Yamaha XJR1300 ", 11000);

            Dictionary<int, Véhicule> Véhicules = new Dictionary<int, Véhicules.Véhicule>();
            Véhicules.Add(V3.Prix, V3);
            Véhicules.Add(V4.Prix, V4);
            Véhicules.Add(V5.Prix, V5);
            Véhicules.Add(V6.Prix, V6);

            Console.OutputEncoding = Encoding.Unicode; // Pour ajouter le symbole €

            foreach (var v in Véhicules)
            {
                Console.WriteLine("{0} : {1} €", v.Value.Nom, v.Value.Prix);
            }

            SortedList<int, Véhicule> ListVéhicule = new SortedList<int, Véhicule>();
            foreach (var v in Véhicules)
            {
                ListVéhicule.Add(v.Key, v.Value);
            }

            //Véhicules.Clear();

            foreach (var v in ListVéhicule)
            {
                Console.WriteLine("{0} € : {1} ", v.Key, v.Value.Nom);
            }

            Véhicules.Clear();

                Console.ReadLine();

        }


    }
    public enum Energies { Aucun, Essence, Gazole, GPL, Electrique }
}
