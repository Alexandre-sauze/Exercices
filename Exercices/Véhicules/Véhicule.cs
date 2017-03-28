using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public class Véhicule
    {
        public string Nom { get; }
        public int NbRoues { get; }
        public Energies Energie { get; }
        public virtual string Description
        {
            get
            {
                return string.Format("Véhicule {0} roule sur {1} roues et à l'énergie {2}", Nom, NbRoues, Energie);
            }
        }

        public Véhicule(string nom, int nbRoues, Energies energie)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;
        }
    }

    
    public class Voiture : Véhicule
    {
        public Voiture(string nom, Energies energie) : base(nom, 4, energie)
        {

        }
    }
}
