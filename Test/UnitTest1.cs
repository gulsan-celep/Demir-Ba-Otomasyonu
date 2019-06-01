using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazilimSinama;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DBOperasyon d = new DBOperasyon();
            List<string[]> tmp = d.PersonelUzerindeDemirbasArama(15);
            Assert.AreEqual(2, tmp.Count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DBOperasyon d = new DBOperasyon();
            bool result = d.Insert("test2", "test-soyad2", "123123124");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DBOperasyon d = new DBOperasyon();
            bool result = d.InsertOda("LAB-2", 2);
            Assert.IsTrue(result);
        }
    }
}
