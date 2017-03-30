using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boites;

namespace Boites
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVolumeBoite()
        {
            Boite t1 = new Boite(10,10,10);

            Assert.AreEqual(1000, t1.Volume);

        }
        [TestMethod]
        public void TestCompteur()
        {
            Boite[] b = new Boite[4];

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = new Boite();
            }

            Assert.AreEqual(5, Boite.Compteur);
        }
    }
}
