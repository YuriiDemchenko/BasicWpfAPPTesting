using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Threading;

namespace Wpf.Tests
{
    [TestClass]
    public class WPFTests : TestsBase
    {
        [TestInitialize]
        public void TestInitialize()
        {
            Initialize();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Cleanup();
        }

        [ClassCleanup]
        public static void ClassCleanusp()
        {
            StopWinappDriver();
        }

        [TestMethod]
        public void ButtonClick()
        {
            this.GetTextField().SendKeys("Newcomer");
            this.GetButtonSend().Click();
            Assert.AreEqual(this.GetTextBlock().Text, "Hello Newcomer");
        }

        [TestMethod]
        public void CheckCheckbox()
        {
            this.GetButtonSend().Click();
            Assert.IsTrue(this.GetCheckboxStatus().Enabled);
        }

        [TestMethod]
        public void CheckTitle()
        {
            Assert.AreEqual(this.GetLabel().Text, "WPF TESTING");
        }

        [TestMethod]
        public void TextFieldDeleteTextTest()
        {
            this.GetTextField().SendKeys("Some text to delete");
            Thread.Sleep(1000);
            this.SelectAllText();
            this.PerformDelete();
            Assert.AreEqual(this.GetTextField().Text, "");
        }

        [TestMethod]
        public void FindButtonWithoutId()
        {
            this.GetButtonWithoutId().Click();
        }

        [TestMethod]
        public void FindComboBoxWithoutId()
        {
            this.GetComboBoxWithoutId().Click();
        }

        [TestMethod]
        public void FindTextBoxWithoutId()
        {
            this.GetTextBoxWithoutId().SendKeys("Hello there");
        }
    }
}