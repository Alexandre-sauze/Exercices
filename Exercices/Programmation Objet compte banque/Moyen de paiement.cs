using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmation_Objet_compte_banque
{
    public class MoyenPaiement
    {

        public long Numcompte { get; set; }
        public string nomTitulaire { get; set; }
        public string PrénomTitulaire { get; set; }
        public DateTime DateDernierRenouvellement { get; set; }

        public MoyenPaiement()
        {

        }

        public virtual void Renouveler()
        {
            DateDernierRenouvellement = DateTime.Today;
        }
    }

    public class Carte:MoyenPaiement
    {
        public long NumCarte { get; set; }
        public long NumCompte { get; set; }
        public DateTime DateExpiration { get; set; }
        public int CodeVérif { get; set; }
        public int CodeSecret { get; set; }

        public override void Renouveler()
        {
            base.Renouveler();
            DateExpiration = DateExpiration.AddYears(2);
        }

    }

    public class Chéquier : MoyenPaiement
    {
        public int NombreChèque { get; set; }
        public long NumPremierChèque { get; set; }

            public override void Renouveler()
        {
            base.Renouveler();
            NumPremierChèque += NombreChèque;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format
        }

        public override string ToString()
        {
            return string.Format("Moyen de paiementassocié au compte {0} de {1} {2}, renouvelé le {3:d}", Numcompte, PrénomTitulaire,
                nomTitulaire);
        }

        public override string ToString()
        {
            String s = base.ToString();
            return s + ToString() + string.Format("Carte de n°{0}, de code secret {1} qui expire le {2}", NumCarte, CodeSecret, DateExpiration);
        }
    }

}
