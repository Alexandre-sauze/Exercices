using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Veillez saisir un login d'au moin 5 caractères :");
            bool erreur = true; // obligé d'initialiser
            while (erreur==true) // défini la condition de boucle, tant que cette condition est respecté, la boucle continue, si erreur Vrai
            {
                erreur = false;// condition de sortie de la boucle, on la réinitialise après chaque passage


                string login = Console.ReadLine();
                try
                {
                    CheckLogin(login);
                    Console.WriteLine("Veillez saisir un mot de passe entre 6 et 12 caractères, il ne doit ni commencer ou finir par un espace :");
                    string motDePass = Console.ReadLine();
                    CheckMotDePass(motDePass);
                    Console.WriteLine("Votre compte a bien été créé.Un message vient de vous être envoyé");
                }
                catch (FormatException e) //e fait référence à l'erreur de la fonction checklogin (focntion qui est dans le try)
                {
                    Console.WriteLine(e.Message); //e.message veut dire que j'affiche le message contenu dans e
                    erreur = true;
                }
            }

            Console.ReadKey();
        }

        static void CheckLogin(string login)
        {
            if (login.Length < 5)
            {
                //Console.WriteLine("Pas Bon, recommencez"); je le traite en dessous comme un erreur
                throw new FormatException("login Pas Bon, recommencez");
            }
        }

        static void CheckMotDePass(string motDePass)
        {
            if (motDePass.Length < 6 || motDePass.Length > 12 || motDePass[0] == ' ' || motDePass[11] == ' ')
            {
                //Console.WriteLine("Pas Bon, recommencez");
                throw new FormatException("mot de passe Pas Bon, recommencez");
            }
        }
    }
}
