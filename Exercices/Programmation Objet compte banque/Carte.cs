using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmation_Objet_compte_banque
{
    public class Carte
    {
        public long NumCarte { get; set; }
        public long NumCompte { get; set; }
        public DateTime DateExpiration { get; set; }
        public int CodeVérif { get; set; }
        public int CodeSecret { get; set; }

    }
}
