using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace Wpf.Tests
{
    public static class TestsBaseExtensions
    {
        private const string textBox = "textbox1";
        private const string textBlock = "textblock1";
        private const string checkBox = "checkbox1";
        private const string buttonSend = "button1";
        private const string title = "label1";

        public static WindowsElement GetTextField(this TestsBase testsBase)
        {
            return testsBase.AppSession.FindElementByAccessibilityId(textBox);
        }

        public static WindowsElement GetTextBlock(this TestsBase testsBase)
        {
            return testsBase.AppSession.FindElementByAccessibilityId(textBlock);
        }

        public static WindowsElement GetCheckboxStatus(this TestsBase testsBase)
        {
            return testsBase.AppSession.FindElementByAccessibilityId(checkBox);
        }

        public static WindowsElement GetLabel(this TestsBase testsBase)
        {
            return testsBase.AppSession.FindElementByAccessibilityId(title);
        }

        public static WindowsElement GetButtonSend(this TestsBase testsBase)
        {
            return testsBase.AppSession.FindElementByAccessibilityId(buttonSend);
        }

        //public static WindowsElement GetElementByName(this TestsBase testsBase, string elementName)
        //{
        //    try
        //    {
        //        return testsBase.AppSession.FindElementByName(elementName);
        //    }
        //    catch
        //    {
        //        Logger.LogMessage("Element was not found using the AppSession. Trying to locate the element using the DesktopSession.");
        //    }

        //    return testsBase.DesktopSession.FindElementByName(elementName);
        //}

        //public static WindowsElement GetElementByAutomationId(this TestsBase testsBase, string automationId)
        //{
        //    try
        //    {
        //        return testsBase.AppSession.FindElementByName(automationId);
        //    }
        //    catch
        //    {
        //        Logger.LogMessage("Element was not found using the AppSession. Trying to locate the element using the DesktopSession.");
        //    }

        //    return testsBase.DesktopSession.FindElementByName(automationId);
        //}
    }

}
