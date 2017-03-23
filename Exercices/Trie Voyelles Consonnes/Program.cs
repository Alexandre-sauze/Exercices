using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie_Voyelles_Consonnes
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Saisie du mot + création de la variable mot pour le stocker
            Console.WriteLine(@"Saisissez un mot SVP");
            string mot = Console.ReadLine();
            int nbConsonnes, nbVoyelles;
            CompterConsonnes(mot, out nbConsonnes);
            Console.WriteLine("Le mot comporte {0} consonnes, {1} de voyelles.", nbConsonnes, nbVoyelles);

        }
        static void CompterConsonnes(string mot, out int consonnes)
        {
            for(int compteurMots = 0; compteurMots < mot.Length; compteurMots++)
            {
                if (mot[compteurMots] != 'a'  )

            }




        }

    }
}

