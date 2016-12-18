using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestImplicitneEksplicitnePretvorbe : ConsoleTest
    {
        [TestMethod]
        public void ImplicitneEksplicitnePretvorbe_IspisujeBrojElemenataTeSveElemente()
        {
            Queue<int> brojevi = new Queue<int>(new int[] { 1, 3, 5, 7, 9 });
            ImplicitnaEksplicitnaPretvorba.IspišiSveElemente(brojevi);
            Assert.AreEqual(6, cw.Count);
            Assert.AreEqual(5, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(3, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());
        }
    }
}
