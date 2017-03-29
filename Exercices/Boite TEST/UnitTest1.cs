using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boites;

namespace Boite_TEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVolumeBoite()
        {
            Boite t1 = new Boite(10, 10, 10);

            Assert.AreEqual(1000, t1.Volume);

        }
    }
}
