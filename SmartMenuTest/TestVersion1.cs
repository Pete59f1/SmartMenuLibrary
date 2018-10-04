using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartMenuLibrary;

namespace SmartMenuTest
{
    [TestClass]
    public class TestVersion1
    {

        [TestMethod]
        public void ActivateMenu()
        {
            SmartMenu menu = new SmartMenu();
            Assert.AreEqual("Vælg sprog - Choose language:\n Tryk D for Dansk\n Press E for English", menu.Activate());
        }
    }
}