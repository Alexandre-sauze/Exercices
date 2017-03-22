using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombres_premiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrer un nombre");
            string Nombre = Console.ReadLine();
            int nbr= int.Parse(Nombre); // plage de nombre a étudier
            bool Est_premier; // Defini la varaible qui prendra la valeur de : est ce que ce nombre est premier ==> Soit vrai ou faux
            int compteur = 0; // On defini un compteur pour afficher la quantité de nombre premier (on stock la quantité)

            for (int i = 2; i <= nbr; i++) // On parcour la plage de nombres jusque NBR)
            {
                Est_premier = true;
                for (int k = 2; k < i; k++) // On commence la question, premier ou pas
                {
                    if (i % k == 0) // est-il divisible par autre chose que lui meme ou 1
                    {
                        Est_premier = false; //Alors il n'est pas premier
                    }
                }
                if(Est_premier==true) // on dit que si la varaible nombre premier est vrai alors
                {
                    compteur = compteur + 1; // alors on ajoute 1 au compteur

                }
             }
            Console.WriteLine("Il y a " + compteur + " nombres premiers");
            Console.ReadKey();
            
        }
    }
}
