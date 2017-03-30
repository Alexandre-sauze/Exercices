using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statuts
{
    class Program
    {
        static void Main(string[] args)
        {
            Statuts CDDCH = Statuts.CDD | Statuts.CHSCT;
            Statuts CDIDP = Statuts.CDI | Statuts.DP;



            List<Personne> Liste = new List<Personne>{
            new Personne("TURPIN", "Abel", Statuts.CDI),
            new Personne("BONNEAU", "Achille", Statuts.CDD | Statuts.DP),
            new Personne("BLONDEL", "Adelphe", Statuts.CDI | Statuts.DP | Statuts.CHSCT | Statuts.SYND),
            new Personne("BLACK", "Aimé", Statuts.CDI),
            new Personne("PERRIER", "Aimée", Statuts.CDI),
            new Personne("JORDAN", "Alain", Statuts.CDD | Statuts.CHSCT),
            new Personne("BAUDRY", "Alban", Statuts.CDD),
            new Personne("ORLEANS", "Albert", Statuts.CDI | Statuts.DP | Statuts.SYND),
            new Personne("VALOIS", "Alexandra", Statuts.CDI | Statuts.SYND),
            new Personne("WEST", "Alexandre", Statuts.CDI | Statuts.DP | Statuts.SYND)
            };

            List<Personne> Liste2 = new List<Personne>();

            List<Personne> Liste3 = new List<Personne>();

            foreach (var a in Liste)
            {
                if ((a.Statut & CDDCH) == CDDCH)
                {
                    Liste2.Add(a);
                }
            }
            foreach (var b in Liste)
            {
                //Console.WriteLine(b);
                //b.Statut = Statuts.CHSCT;
                //Console.WriteLine(b);
                if ((b.Statut & CDIDP) == CDIDP)
                {
                    Liste3.Add(b);
                }
            }
        }
    }
}

