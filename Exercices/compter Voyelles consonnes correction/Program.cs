using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compter_Voyelles_consonnes_correction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("saisissez un mot");
            string mot = Console.ReadLine();

            int nbVoyelles, nbConsonnes;
            CompterVoyellesConsonnes(mot, out nbVoyelles, out nbConsonnes);
            Console.WriteLine("Le mot {0} comporte {1} voyelles et {2} consonnes", mot, nbVoyelles, nbConsonnes);
            Console.ReadKey();
        }

        static void CompterVoyellesConsonnes(string mot, out int nbVoy, out int nbCons)
        {
            nbVoy = 0;

            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == 'a' || mot[i] == 'e' || mot[i] == 'i' || mot[i] == 'o' || mot[i] == 'u' || mot[i] == 'y')
                {
                    nbVoy++;
                }
            }
            nbCons = mot.Length - nbVoy;

        }
    }
}
