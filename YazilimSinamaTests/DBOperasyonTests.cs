using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazilimSinama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinama.Tests
{
    [TestClass()]
    public class DBOperasyonTests
    {
        [TestMethod()]
        public void TestExceptionCase()
        {
            DBOperasyon d = new DBOperasyon();
            d.StokListele();
            try
            {
                d.kontrol = "Sandalye";
                
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Oda id=1");
            }
           
            Assert.Fail("No exception was thrown");
        }
        public void TestExceptionCase2()
        {
            DBOperasyon d = new DBOperasyon();
            d.Arama(1);
            try
            {
                d.kontrol = "Sandalye";

            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Oda id=1");
            }

            Assert.Fail("No exception was thrown");
        }
        public void TestExceptionCase3()
        {
            DBOperasyon d = new DBOperasyon();
            d.PersonelUzerindeDemirbasArama(15);
            try
            {
                d.kontrol =(4).ToString();

            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Oda id=1");
            }

            Assert.Fail("No exception was thrown");
        }
    }
}