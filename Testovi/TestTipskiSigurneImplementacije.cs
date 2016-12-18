using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestTipskiSigurneImplementacije : ConsoleTest
    {
        [TestMethod]
        public void TipskiSigurneImplementacije_UsporedbaDvijuDuljinaVraćaVećeOdNuleAkoJePrvaDuljinaVeća()
        {
            TipskiSigurneImplementacije.Duljina d1 = new TipskiSigurneImplementacije.Duljina(5);
            TipskiSigurneImplementacije.Duljina d2 = new TipskiSigurneImplementacije.Duljina(3);
            TipskiSigurneImplementacije.Usporedi(d1, d2);
            Assert.IsTrue(cw.GetString().Contains(">"));
        }

        [TestMethod]
        public void TipskiSigurneImplementacije_UsporedbaDvijuDuljinaVraćaVećeManjeOdNuleAkoJePrvaDuljinaManja()
        {
            TipskiSigurneImplementacije.Duljina d1 = new TipskiSigurneImplementacije.Duljina(3);
            TipskiSigurneImplementacije.Duljina d2 = new TipskiSigurneImplementacije.Duljina(5);
            TipskiSigurneImplementacije.Usporedi(d1, d2);
            Assert.IsTrue(cw.GetString().Contains("<"));
        }

        [TestMethod]
        public void TipskiSigurneImplementacije_UsporedbaDvijuDuljinaVraćaNuluAkoJePrvaDuljinaJednakaDrugoj()
        {
            TipskiSigurneImplementacije.Duljina d1 = new TipskiSigurneImplementacije.Duljina(3);
            TipskiSigurneImplementacije.Duljina d2 = new TipskiSigurneImplementacije.Duljina(3);
            TipskiSigurneImplementacije.Usporedi(d1, d2);
            Assert.IsTrue(cw.GetString().Contains("="));
        }
    }
}
