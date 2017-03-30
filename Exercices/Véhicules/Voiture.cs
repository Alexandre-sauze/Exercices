using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public class Voiture : Véhicule
    {
        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {

        }
        public Voiture(string nom, int prix) : base(nom, prix)
        {

        }

        public override int PrixRevientKM
        {
            get
            {
                return 12;
            }
        }

        public override void CalculerConso()
        {
            throw new NotImplementedException();
        }
    }
}
