using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestDefinicijaImplementacijaSučelja
    {
        [TestMethod]
        public void DefinicijaImplementacijaSučelja_SvojstvoVraćaZadanuVrijednost()
        {
            IMojeSučelje i = (IMojeSučelje)(new Implementacija());
            i.Svojstvo = "abcd";
            Assert.AreEqual("abcd", i.Svojstvo);
        }

        [TestMethod]
        public void DefinicijaImplementacijaSučelja_PozivMetodeGeneriraDogađaj()
        {
            IMojeSučelje i = (IMojeSučelje)(new Implementacija());
            događajJeObrađen = false;
            i.MojDogađaj += ObradaDogađaja;
            i.GenerirajMojDogađaj();
            Assert.AreEqual(true, događajJeObrađen);
        }

        void ObradaDogađaja(object sender, EventArgs args)
        {
            događajJeObrađen = true;
        }

        private bool događajJeObrađen = false;
    }
}
