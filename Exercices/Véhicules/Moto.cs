using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    class Moto:Véhicule
    {
        public Moto(string nom, Energies energie) : base(nom, 2, energie)
        {

        }
        public override string Description
        {
            get
            {
                return "Je suis une moto\r\n" + base.Description;
            }
        }
    }
}
