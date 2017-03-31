using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace RelevésMétéo
{
    public class AnalyseurLINQ
    {
        private List<DonnéesMois> _data;
        public List<DonnéesMois> Data
        {
            get { return _data; }
        }

        public AnalyseurLINQ()
        {
            _data = new List<DonnéesMois>();
        }

        public void ChargerDonnées()
        {
            string chemin = @"..\..\DonnéesMétéoParis.txt";

            int cpt = 0;
            using (StreamReader str = new StreamReader(chemin))
            {
                string ligne;

                while ((ligne = str.ReadLine()) != null)
                {
                    cpt++;
                    if (cpt == 1) continue; // On n'analyse pas la première ligne car elle contient les en-têtes

                    var tab = ligne.Split('\t');
                    try
                    {
                        var donnéesMois = new DonnéesMois
                        {
                            Mois = DateTime.Parse(tab[0]),
                            TMin = double.Parse(tab[1]),
                            TMax = double.Parse(tab[2]),
                            Précipitations = double.Parse(tab[3]),
                            Ensoleillement = double.Parse(tab[4])
                        };

                        // Ajout des données du mois à la liste
                        Data.Add(donnéesMois);
                    }
                    catch (FormatException)
                    {
                        // On ignore simplement la ligne
                        Console.WriteLine("Erreur de format à la ligne suivante :\r\n{0}", ligne);
                    }
                }
            }
        }

        public void AfficherStats()
        {
            // mois de la température min la plus basse
            //var res1 = Data.Min(t => t.TMin);
            //var res2 = Data.Where(m => m.TMin == res1).First();
            var res = Data.Where(m => m.TMin == Data.Min(t => t.TMin)).First();

            //Data.OrderBy(m => m.Tmin).First().


            // Sommes des précipitations de l'année 2016


            //var res1 = Data.Where(y => y.Mois.Year == 2016);
            //var res2 = res1.Sum(p => p.Précipitations);
            var res3 = Data.Where(y => y.Mois.Year == 2016).Sum(p => p.Précipitations);


            // Durée d'ensoleillement moyenne du mois de Juillet sur toutes les années
            var res4 = Data.Where(y => y.Mois.Month == 7).Average(e => e.Ensoleillement);

            // Précipitations moyennes par année
            var année = Data.Select(d => d.Mois.Year).Distinct();

            foreach (var an in année)
            {
                var res5 = Data.Where(y => y.Mois.Year == an).Average(p => p.Précipitations);
            }
        }
    }

    /// <summary>
    /// Classe contenant les données d'un mois de relevé météo
    /// </summary>
    public class DonnéesMois
    {
        public DateTime Mois { get; set; }
        public double TMin { get; set; }
        public double TMax { get; set; }
        public double Précipitations { get; set; }
        public double Ensoleillement { get; set; }
    }
}
