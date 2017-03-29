using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boites
{
    class Program
    {
        static void Main(string[] args)
        {
            Boite b1 = new Boite(30, 60, 20);
            Boite b2 = new Boite(24, 56, 74, TypeMatière.métal);
            Etiquette Eti = new Etiquette { Format = Formats.xl, Texte = "dkqsgfjd", Couleur = TypeCouleurs.Marron };
            Console.WriteLine(Boite._nbBoite);
            Boite b3 = new Boite(200, 400, 250);
            b3.Etiqueter("Alexandre", true);
            Boite b4 = new Boite(30, 60, 20);
            b4.Etiqueter(Eti, Eti);
            b1.Etiqueter("M.Dupont Jean", true);


        }
    }


    public enum TypeCouleurs { Blanc, Bleu, Vert, Jaune, Orange, Rouge, Marron }
    public enum TypeMatière { carton, plastique, bois, métal}

    
}
