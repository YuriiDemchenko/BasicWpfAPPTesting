using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Wpf.Tests
{
    [TestClass]
    public class WPFTests : TestsBase
    {
        [TestInitialize]
        public void TestInitialize()
        {
            this.Initialize();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.Cleanup();
        }

        [ClassCleanup]
        public static void ClassCleanusp()
        {
            StopWinappDriver();
        }

        [TestMethod]
        public void ButtonClick()
        {
            this.GetTextField().SendKeys("Deedg");
            this.GetButtonSend().Click();
        }

        [TestMethod]
        public void CheckCheckbox()
        {
            var found = this.GetCheckboxStatus();
            this.GetButtonSend().Click();
            Assert.IsTrue(found.Enabled);
        }

        [TestMethod]
        public void CheckTitle()
        {
            Assert.AreEqual(this.GetLabel().Text, "WPF TESTING");
        }
    }
}