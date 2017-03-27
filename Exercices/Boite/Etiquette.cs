using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boite
{
    public enum Formats
    {
        xs,s, m, l, xl
    }
    public class Etiquette
    {
        public TypeCouleurs Couleur { get; set; }
        public Formats Format { get; set; }
        public string Texte { get; set; }
    }
}
