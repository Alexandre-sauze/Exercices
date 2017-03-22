using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trier_un_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création et insertion des infos dans le tableau + création de stock
            string[] tabPos = new string[4]; //on peut aussi initialiser les éléments de cette façon : {"Alfa", "Charli", ...);
            tabPos[0] = "Alfa ";
            tabPos[1] = "Charlie ";
            tabPos[2] = "Sierra ";
            tabPos[3] = "Bravo ";
            string stock;

            //Affichage du tableau
            //Console.WriteLine(tabPos[0] + tabPos[1] + tabPos[2] + tabPos[3]);
            FonctionAffichage(tabPos);
            //Reglage de la boucle
            TrierTableau(tabPos);
            //for (int compteurlongueurtab = 0; compteurlongueurtab < tabPos.Length - 1; compteurlongueurtab++)
            {
                //Comparaison
               // int resultatComparaison = tabPos[compteurlongueurtab].CompareTo(tabPos[compteurlongueurtab + 1]);

                //Condition
               // if (resultatComparaison > 0)
                {
                  //  stock = tabPos[compteurlongueurtab + 1];
                   // tabPos[compteurlongueurtab + 1] = tabPos[compteurlongueurtab];
                   // tabPos[compteurlongueurtab] = stock;
                   // compteurlongueurtab = -1;
                }

            }


            Console.WriteLine(tabPos[0] + tabPos[1] + tabPos[2] + tabPos[3]);

            Console.ReadKey();

        }

        static void FonctionAffichage(string[] tableau)
        {
            for (int compteurlongueurtab = 0; compteurlongueurtab < tableau.Length; compteurlongueurtab++)
                Console.Write(" " + tableau[compteurlongueurtab]);
                Console.WriteLine(" ");
        }

        static void TrierTableau(string[] tableau)
        {
            for (int compteurlongueurtab = 0; compteurlongueurtab < tableau.Length - 1; compteurlongueurtab++)
            {
                int resultatComparaison = tableau[compteurlongueurtab].CompareTo(tableau[compteurlongueurtab + 1]);
                if (resultatComparaison > 0)
                {
                    string stock;
                    stock = tableau[compteurlongueurtab + 1];
                    tableau[compteurlongueurtab + 1] = tableau[compteurlongueurtab];
                    tableau[compteurlongueurtab] = stock;
                    compteurlongueurtab = -1;
                }
           }
        }
    }

}
