using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boite
{
    public class Boite
    {
        public static int _nbBoite = 0;
        #region Champs Privé
        private double _hauteur = 30;
        private double _largeur = 30;
        private double _longueur = 30;
        private Etiquette _etiquetteDest, _etiquetteFragile;
        #endregion

        #region propriétés
        public double Hauteur
        {
            get { return _hauteur; }

        }
        public TypeCouleurs _Couleurs {get; set;}
        public TypeMatière _matières {get;}
        public double Volume
        {
            get { return _hauteur * _largeur * _longueur; }
        }
        #endregion

        #region Methode Publique
        public void Etiqueter(string destinataire)
        {
            Etiquette E1 = new Etiquette { Couleur = TypeCouleurs.Blanc, Format = Formats.l, Texte = destinataire };
            _etiquetteDest = E1;
        }
        public void Etiqueter(string destinataire, bool fragile)
        {
            if(fragile==true)
            {
                Etiquette E1 = new Etiquette { Couleur = TypeCouleurs.Rouge, Format = Formats.s, Texte = "fragile" };
                _etiquetteFragile = E1;
            }
            
            Etiqueter(destinataire);
        }

        public void Etiqueter(Etiquette Destinataire, Etiquette Fragile)
        {
            _etiquetteDest = Destinataire;
            _etiquetteFragile = Fragile;
        }
        public bool Compare(Boite autreBoite)
        {
            if ((this._hauteur == autreBoite._hauteur) && (this._largeur == autreBoite._largeur) && (this._longueur == autreBoite._longueur))
            {
            return true;
            }
            else
                return true;
        }
        #endregion

        #region Constructeur
        public Boite(double hauteur, double largeur, double longueur)
        {
            _hauteur = hauteur;
            _largeur = largeur;
            _longueur = longueur;
            _nbBoite++;
        }
        public Boite(double hauteur, double largeur, double longueur, TypeMatière Matière) : this(hauteur, largeur, longueur)
        {
            _matières = Matière;

        }
        #endregion
    }
}