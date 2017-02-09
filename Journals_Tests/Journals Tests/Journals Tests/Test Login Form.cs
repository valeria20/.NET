using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;


namespace Journals_Tests
{
    [TestClass]
    public class Test_Login_Form
    {
        //[TestMethod]
        //public void TestNavigationMenu()
        //{

        //    foreach (var journal in Journals.GetNamesOfJournals())
        //    {
        //        WebDriver.getDriver.Navigate().GoToUrl($"http://journals.lww.com/{journal}/pages/default.aspx");
        //        foreach (var externalElement in Navigation_Elements.GetExternalElements())
        //        {
        //            IWebElement element= WebDriver.getDriver.FindElement(By.LinkText(externalElement));
        //            element.Click();
        //            //foreach (var internalElement in Navigation_Elements.GetInternalElements())
        //            //{
        //            //    IWebElement internalElements = WebDriver.getDriver.FindElement(By.LinkText(internalElement));  
        //            //}
        //        }
        //    }    

        //}



        [TestMethod]
        public void TestLoginFormIsAvailable()
        {
            WebDriver.getDriver.Navigate().GoToUrl("http://journals.lww.com/");
            IWebElement element = WebDriver.getDriver.FindElement(By.Id("ctl00_ucUserActionsToolbar_lnkLogin"));
            element.Click();

            string act = WebDriver.getDriver.Title;
            string ex = "Login";
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(ex, act);
        }


        [TestMethod]
        [Test, TestCaseSource("ValidLoginAndPassword")]
        public void LoginPositiveTests(string username, string password)
        {
            WebDriver.getDriver.Navigate().GoToUrl("http://journals.lww.com/");
            IWebElement element = WebDriver.getDriver.FindElement(By.Id("ctl00_ucUserActionsToolbar_lnkLogin"));
            element.Click();
            IWebElement usernameField = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$txt_UserName"));
            usernameField.SendKeys(username);
            IWebElement passwordField = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$txt_Password"));
            passwordField.SendKeys(password);
            IWebElement loginButton = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$LoginButton"));
            loginButton.Click();
            IWebElement logOut = WebDriver.getDriver.FindElement(By.Id("ctl00_ucUserActionsToolbar_lnkLogout"));
            logOut.Click();

        }

        [TestMethod]
        [Test, TestCaseSource("InvalidLoginAndPassword")]

        public void LoginNegativeTests(string username, string password)
        {
            WebDriver.getDriver.Navigate().GoToUrl("http://journals.lww.com/");
            IWebElement element = WebDriver.getDriver.FindElement(By.Id("ctl00_ucUserActionsToolbar_lnkLogin"));
            element.Click();
            IWebElement usernameField = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$txt_UserName"));
            usernameField.SendKeys(username);
            IWebElement passwordField = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$txt_Password"));
            passwordField.SendKeys(password);
            IWebElement loginButton = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$LoginButton"));
            loginButton.Click();
            IWebElement usernameClear = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$txt_UserName"));
            usernameClear.Clear();
            string actual = WebDriver.getDriver.Title;
            string expected = "Login";
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }



        static object[][] ValidLoginAndPassword = {
        new object[] { "Valeryia", "ZCwiAhZ789" },
        new object[] { "sholomova96@gmail.com", "ZCwiAhZ789" }

    };


        static object[][] InvalidLoginAndPassword = {
        new object[] {"qvh", "hvyo34"},
        new object[] { "efrwe", "ZCwiAhZ789" },
        new object[] { "Valeryia", "76478" },
        new object[] { "Valeryia", ""},
        new object[] {"", "ZCwiAhZ789" },
        new object[] {" Valeryia", "ZCwiAhZ789"},
        new object[] {"", "" }
    };
        [TestCleanup]
        public void KillDriver()
        {
            WebDriver.KillDriver();
        }
    }

}

