using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{

    public class Moto : Véhicule
    {
        public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {

        }
        public Moto(string nom, int prix) : base(nom, prix)
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
