using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmation_Objet_compte_banque
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2017, 02, 25);
            CompteBancaire cb = new CompteBancaire(dt, Typecompte.courant);
            Carte carte = new Programmation_Objet_compte_banque.Carte
            {
                NumCompte = 1589879621475,
                NumCarte = 75368115452,
                DateExpiration = DateTime.Today.AddYears(2),
                //CodeSecret = 7865,
                CodeVérif = 423
            };
            bool b = cb.ADécouvert;
            cb.Créditer(400);
            Console.WriteLine("Solde courant : {0}", cb.SoldeCourant);

            cb.Débiter(600);
            Console.WriteLine("Solde courant : {0}", cb.SoldeCourant);

            cb.Débiter(2000);
            Console.WriteLine("Solde courant : {0}", cb.SoldeCourant);
            Console.ReadKey();

        }
    }

    public enum Typecompte { courant, Epargne, PEA, PEE}
    public class CompteBancaire
    {

        #region Champs privés
        private bool _aDécouvert;
        private DateTime _dateCréation;
        private DateTime _dateCloture;
        private decimal _soldeCourant;
        private decimal _découvertAutorisé;
        private Typecompte _type;
        #endregion

        /// <summary>
        /// Date de création du compte
        /// </summary>
        public CompteBancaire()
        {
            _dateCréation = DateTime.Today;
        }

        /// <summary>
        /// Date de création du compte
        /// </summary>
        /// <param name="dateCréa">date de création</param>
        public CompteBancaire(DateTime dateCréa, Typecompte type)
        {
            _dateCréation = dateCréa;
            _type = type;
        }

        /// <summary>
        /// Création d'un compte avec date de création et solde
        /// </summary>
        /// <param name="dateCréa">date de création</param>
        /// <param name="solde">solde</param>
        public CompteBancaire(DateTime dateCréa, decimal solde)
        {
            _dateCréation = dateCréa;
            _soldeCourant = solde;
        }

        #region Propriété
        public bool ADécouvert
        {
            get { return _aDécouvert; }

        }

        public DateTime DateCloture
        {
            get { return _dateCloture; }
        }

        public DateTime DateCréation
        {
            get { return _dateCréation;  }
        }

        public decimal SoldeCourant
        {
            get { return _soldeCourant;  }
        }

        public decimal DécouvertAutorisé
        {
            get { return _découvertAutorisé; }
            set { _découvertAutorisé = value;  }
        }
        #endregion


        #region Méthode privées
        private int calculerAncienneté()
        {
            //int anc = (DateTime.Today - _dateCréation).Days; idem à en dessous
            return (DateTime.Today - _dateCréation).Days;
            //return anc;
        }

        private decimal CalculerIntérêts()
        {
            return 0;
        }

        private decimal CalculerSolde()
        {
            return _soldeCourant + CalculerIntérêts();
        }

        #region methode public


        public void Cloturer()
        {
            _dateCloture = DateTime.Today;
            CalculerSolde();

        }

        public void Créditer(decimal montant)
        {
            _soldeCourant += montant;
        }

        public void Débiter(decimal montant)
        {
            _soldeCourant -= montant;
            if (_soldeCourant < _découvertAutorisé)
            {
                _soldeCourant -= 5;
            }
            if (_soldeCourant < 0)
            _aDécouvert = true;
        }
        #endregion

        #endregion

    }
}
