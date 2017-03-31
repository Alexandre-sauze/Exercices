using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevésMétéo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var al = new AnalyseurLINQ();
            al.ChargerDonnées();
            Console.ReadKey();
        }
    }
}
