﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boite
{
    public class Article : IComparable
    {
        public int Id { get; set; }

        public string Libellé { get; set; }

        public double Poids { get; set; }

        public Article(int id, string libellé, double poids)
        {
            Id = id;
            Libellé = libellé;
            Poids = poids;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", Id, Libellé, Poids);
        }

        public int CompareTo(object obj)
        {
            Article a = (Article)obj;
            return Poids.CompareTo(a.Poids);
        }
    }
}
