using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boite
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }


    public enum TypeCouleurs { Blanc, Bleu, Vert, Jaune, Orange, Rouge, Marron }
    public enum TypeMatière { carton, plastique, bois, métal}

    public class Boite
    {
        #region Champs Privé
        private double _hauteur = 30;
        private double _largeur = 30;
        private double _longueur = 30;
        private TypeCouleurs _couleurs;
        private TypeMatière _matières = TypeMatière.carton;
        #endregion

        #region propriétés
        public double Hauteur
        {
            get { return _hauteur; }

        }
        public TypeCouleurs Couleurs
        {
            get { return _couleurs; }
            set { _couleurs = value; }
        }
        public TypeMatière matières
        {
            get { return _matières; }
        }
        public double Volume
        {
            get { return _hauteur*_largeur*_longueur; }
        }
        #endregion

        #region Methode Publique
        public void Etiqueter(string destinataire)
        {

        }
        public void Etiqueter(string destinataire, bool fragile)
        {

        }

        #endregion
    }
}
