using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainement
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            Console.ReadKey();
        }

        static void Demo() // Entête de la fonction (les acolade en dessous c'est le corp)
        {
            string texte;
            string phrase;
            int nbPhrases, nbmots, nbCaractères; // Plusieurs déclarations

            const double PI = 3.1415926;
            const string DEB_LIST = "";


            phrase = "Le c# est un langage moderne et puissant!"; // la variable phrase est égale à ce qui est entre guillements
            texte = phrase; // la variable texte est égale à la variable phrase
            texte = texte + "Il est utilisé pour toutes sortes d'applications\n"; // J'ajoute à la ligne du contenu à ma variable texte qui était anciennement phrase
            texte = texte + DEB_LIST + "Application console\n"; // ou on peut écrire texte += ... comme en dessous
            texte += DEB_LIST + "Application fenétrée Winforms et WPF\n";

            Console.WriteLine(texte);
            char Lettre; // on défini que lettre est une simple lettre
            Lettre = phrase[32]; // on demande d'afficher la lettre 32 de la phrase contenue dans phrase
            Console.WriteLine(Lettre);

            short S = 2;
            S += 1; // Correspond à S = S + 1, ça évite de répéter 2 fois le S
            S++; // On ajoute S à S
            Console.WriteLine("La valeur de S est : " + S); // On demande d'afficher le texte entre guillement puis le résultat de la variable S

            //int[] tabPos = new int[3]; // cela permet de déclarer un tableau de 3 entiers
            //tabPos[0] = 3;
            //tabPos[1] = 4;
            //tabPos[2] = 8;       OU BIEN
            int[] tabPos = new int[3] { 3, 4, 40 };
            Console.WriteLine(tabPos[2]); // affiche la valeur afficher dans la case 0, 1 ou 2, ...
            Console.WriteLine(tabPos.Length); // Permet d'affiche la longueur du tableau

            for (int i = 0; i < tabPos.Length; i++) // Bloc 1 = initialisation du "commpteur" / Bloc 2 = Bloc ave la condition de fin / Bloc 3 on fait 1+1 jusuq'a ce qu'on atteigne la limite soit 2 étant donné qu'il faut être inferieur à 3
            {   // on peut faire i+=2 pour passer de 2 en 2 ou 1-- pour aller en sens inverse, attention à bien adapter les autres conditions
                Console.WriteLine(tabPos[i]); //Affichage de l'information
                
            }

            int J = 0;
            while (J < tabPos.Length) // tant que J est inferieur à la longueur du tableau on continue
            {
                Console.WriteLine(tabPos[J]);
                J++;
            }

            Console.Clear();
            Console.WriteLine(texte);

            nbPhrases = 0;
            for (int i = 0; i < texte.Length; i++)
            {
                if(texte[i] =='\n') // == Permet de comparer la valeur
                {
                    nbPhrases++;
                }
            }
            Console.WriteLine("il y a " + nbPhrases + " lignes dans le texte");
            Console.Clear();

            nbmots = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                if(phrase [i] == ' ' || phrase [i] == '\''|| phrase[i] == '\n') // Pour écrire une appostrophe il faut écrire \i et pour écrire ou ||
                {
                    nbmots++;
                }
                
            }
            nbmots++;
            Console.WriteLine("il y a " + nbmots + " mots dans le texte");

            Console.WriteLine("entrer un nom");
            string valeur = Console.ReadLine();
            int x = int.Parse(valeur);



        }







    }
}
