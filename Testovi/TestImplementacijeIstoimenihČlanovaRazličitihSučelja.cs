using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestImplementacijeIstoimenihČlanovaRazličitihSučelja : ConsoleTest
    {
        [TestMethod]
        public void ImplementacijaIstoimenihČlanovaRazličitihSučelja_SkokUVis()
        {
            ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac d = new ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac();
            ((ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.ISkokUvis)d).Skoči();
            Assert.AreEqual("Hop u vis", cw.GetString());
        }

        [TestMethod]
        public void ImplementacijaIstoimenihČlanovaRazličitihSučelja_SkokUDalj()
        {
            ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac d = new ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac();
            ((ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.ISkokUdalj)d).Skoči();
            Assert.AreEqual("Hop u dalj", cw.GetString());
        }

        [TestMethod]
        public void ImplementacijaIstoimenihČlanovaRazličitihSučelja_Skoči()
        {
            ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac d = new ImplementacijaIstoimenihČlanovaIzRazličitihSučelja.Desetobojac();
            d.Skoči();
            Assert.AreEqual("Hop", cw.GetString());
        }
    }
}
