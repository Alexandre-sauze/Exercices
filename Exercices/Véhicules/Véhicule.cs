using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Véhicules
{
    public abstract class Véhicule : IComparable
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
        public abstract int PrixRevientKM { get; }



        public Véhicule(string nom, int nbRoues, Energies energie)
        {
            Nom = nom;
            NbRoues = nbRoues;
            Energie = energie;
        }
        public abstract void CalculerConso();

        public int CompareTo(object obj)
        {
            if (obj is Véhicule)
            {
                Véhicule v = (Véhicule)obj;
                if (v.PrixRevientKM == PrixRevientKM)
                {
                    return 0;
                }
                else if (v.PrixRevientKM < PrixRevientKM)
                {
                    return -1;
                }
                else
                {
                    return +1;
                }
            }
            else
                throw new ArgumentException();

        }
    }



}
