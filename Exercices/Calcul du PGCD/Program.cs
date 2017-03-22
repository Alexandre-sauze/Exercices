using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul_du_PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entrer un chiffre");
            string valeur_P = Console.ReadLine();
            int P = int.Parse(valeur_P);

            Console.WriteLine("entrer un chiffre");
            string valeur_Q = Console.ReadLine();
            int Q = int.Parse(valeur_Q);

            while (P!=Q)
            {
                if (P > Q)
                {
                    P = P - Q;
                }
                else
                {
                    Q = Q - P;
                }
            }
            Console.WriteLine("PGCD " + P);
            Console.ReadKey();
        }
        
    }
}
