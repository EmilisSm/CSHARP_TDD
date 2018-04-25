using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest;

namespace TieseTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TiesiesEqual()
        {
            Tiese tiese1 = new Tiese(1, 2, 4, 2);
            Tiese tiese2 = new Tiese(1, 4, 4, 4);

            int expected = tiese2.TiesesIlgis();
            int actual = tiese1.TiesesIlgis();

            Assert.AreEqual(expected, actual, 1, "Tieses nera lygios"); 
        }

        [TestMethod]
        public void TiesesNotEqual()
        {
            Tiese tiese1 = new Tiese(1, 6, 6, 2);
            Tiese tiese2 = new Tiese(1, 2, 4, 2);

            int expected = tiese2.TiesesIlgis();
            int actual = tiese1.TiesesIlgis();

            Assert.AreNotEqual(expected, actual, 1, "Tieses lygios");
        }

        [TestMethod]
        public void TieseNotNull()
        {
            Tiese tiese1 = new Tiese(1, 6, 6, 2);

            int expected = tiese1.TiesesIlgis();

            Assert.IsNotNull(expected, "Tiese is null");
        }

        [TestMethod]
        public void KryptiesKofNotNUll()
        {
            Tiese tiese1 = new Tiese(1, 6, 6, 2);

            int expected = tiese1.KryptiesKof();

            Assert.IsNotNull(expected, "Krypties Kof is null");
        }

        [TestMethod]
        public void KryptiesKofEqual()
        {
            Tiese tiese1 = new Tiese(1, 2, 4, 2);
            Tiese tiese2 = new Tiese(1, 4, 4, 4);

            int expected = tiese2.KryptiesKof();
            int actual = tiese1.KryptiesKof();

            Assert.AreEqual(expected, actual, "Krypties Kof nera lygus");
        }

        [TestMethod]
        public void KryptiesKofNotEqual()
        {
            Tiese tiese1 = new Tiese(1, 6, 4, 2);
            Tiese tiese2 = new Tiese(1, 2, 4, 2);

            int expected = tiese2.KryptiesKof();
            int actual = tiese1.KryptiesKof();

            Assert.AreNotEqual(expected, actual, -1, "Krypties Kof lygus");
        }
    }
}
