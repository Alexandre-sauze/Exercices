using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statuts
{
    [Flags]
    public enum Statuts { AUCUN =0, CDI =1, CDD=2, DP=4, CHSCT=8, SYND=16 }
    public class Personne
    {


        public string Nom { get; set; }
        public string Prénom { get; set; }
        public Statuts Statut { get; set; }


        public Personne(string nom, string prénom, Statuts statut)
        {
            Nom = nom;
            Prénom = prénom;
            Statut = statut;


        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Nom, Prénom, Statut);

        }
    }
}
