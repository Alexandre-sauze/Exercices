using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POO;

namespace Tests
{
    [TestClass]
    public class testcompteBancaire
    {
        [TestMethod]
        public void TestDébitOrdinaire()
        {
            CompteBancaire cb = new CompteBancaire(145896, DateTime.Today, 500);
            cb.Débiter(100);
            Assert.AreEqual(400, cb.SoldeCourant);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDébitAvecDécouvert()
        {
            CompteBancaire cb = new CompteBancaire(145896, DateTime.Today, 500);
            cb.DécouvertAutorisé = -500;
            cb.Débiter(1200);
            Assert.AreEqual(-700, cb.SoldeCourant);



        }
    }
}
