using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombresPremier
{
	class Program
	{
		static void Main(string[] args) // Main = point d'entrée de tout programme
		{
            int n;
			
			Console.Write("Combien de nombres premiers : "); // Write écrit sur la même ligne, pas de nouvelle ligne. permet d'afficher un message
            // string réponse; // on déclare une variable string
            // réponse = console.readline; // La réponse correspondra a ce qu'on a saisi au clavier avant
            // n = int.Pars(réponse); On dit que la variable n défini plus au correspond à la traduction de réponse en un entier
			n = Int32.Parse(System.Console.ReadLine()); // équivalent à au dessus en plus condensé.
            claculerNombrePremier(n);
            claculerNombrePremier(15);
            claculerNombrePremier(19);
            claculerNombrePremier(n);

            Console.ReadKey();

        }

        static void claculerNombrePremier(int nbPremier )
        {
            int divis, nbr, cptPremier = 0; // On déclare des variables qu'on a besoin après. On initilise à 0 car après on cherchera tout de suite à le comparer
            bool estPremier; // Variables booléene c'est à dire qui peut etre vrai ou fausse (true / false).

            Console.WriteLine(2); // On dit que 2 est un nombre 1er, la console l'affichera d'office
            nbr = 3; // donc je commence à 3 // au aura pu initialise nbr plus haut direct à 3
            while (cptPremier < nbPremier - 1) // Boucle While, on a déja écrit 2 donc on demande au compteur de faire -1
            {
                divis = 2;
                estPremier = true; // au début on suppose que le nombre est premier
                do
                {
                    if (nbr % divis == 0) estPremier = false; // On regarde si le reste est de 0, c'est c'es la cas, nombre premier = faux
                    else divis = divis + 1; // incrémenter si le nombre est premier
                }
                while ((divis <= nbr / 2) && (estPremier == true)); // je fait la boucle tant que le diviseur ....
                if (estPremier)
                {
                    cptPremier++;
                    System.Console.WriteLine(nbr);
                }
                nbr++;
            }

        }
	}
}
