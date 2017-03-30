using Boite;
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
            var a1 = new Article(1, "Article 1 ", 540);
            var a2 = new Article(2, "Article 2 ", 200);
            var a3 = new Article(3, "Article 3 ", 600);

            b1.Articles.Add(a1);
            b1.Articles.Add(a2);
            b1.Articles.Add(a1);

            //for (int i =0; i<b1.Articles.Count; i++)
            //{
            //    Console.WriteLine(b1.Articles[i]);
            //    if (b1.Articles[i] is Article)
            //    {
            //        Article a = (Article)b1.Articles[i];
            //       // a.Libellé = "dsqfsdf";
            //    }
            //    else
            //        throw new ArgumentException();
               
            //    //((Article)b1.Articles[i]).Libellé = "dsqfsdf";
            //}
            //b1.Articles.Sort();
            foreach(object a in b1.Articles)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }


    public enum TypeCouleurs { Blanc, Bleu, Vert, Jaune, Orange, Rouge, Marron }
    public enum TypeMatière { carton, plastique, bois, métal}

    
}
