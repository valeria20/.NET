using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Journals_Tests
{
    [TestClass]
    public class TestClass
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

        //[TestMethod]
        //public void TestLoginFormIsAvailable()
        //{
        //    WebDriver.getDriver.Navigate().GoToUrl("http://journals.lww.com/");
        //    IWebElement element = WebDriver.getDriver.FindElement(By.Id("ctl00_ucUserActionsToolbar_lnkLogin"));
        //    element.Click();

        //    string act = WebDriver.getDriver.Title;
        //    string ex = "Login";
        //    Assert.AreEqual(ex, act);
        //}
        [TestMethod]
        public void LoginWithUsername()
        {
            WebDriver.getDriver.Navigate().GoToUrl("http://journals.lww.com/");
            IWebElement element = WebDriver.getDriver.FindElement(By.Id("ctl00_ucUserActionsToolbar_lnkLogin"));
            element.Click();
            IWebElement username = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$txt_UserName"));
            username.SendKeys("Valeryia");
            IWebElement password = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$txt_Password"));
            password.SendKeys("ZCwiAhZ789");
            IWebElement loginButton = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$LoginButton"));
            loginButton.Click();
            IWebElement logOut = WebDriver.getDriver.FindElement(By.Id("ctl00_ucUserActionsToolbar_lnkLogout"));

        }
       

        [TestMethod]
        public void TestLoginWithEmail()
        {
            WebDriver.getDriver.Navigate().GoToUrl("http://journals.lww.com/");
            IWebElement element = WebDriver.getDriver.FindElement(By.Id("ctl00_ucUserActionsToolbar_lnkLogin"));
            element.Click();
            IWebElement username = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$txt_UserName"));
            username.SendKeys("sholomova96@gmail.com");
            IWebElement password = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$txt_Password"));
            password.SendKeys("ZCwiAhZ789");
            IWebElement loginButton = WebDriver.getDriver.FindElement(By.Name("ctl00$ctl45$g_818e981e_cd12_4836_8e55_9fe5e199454d$ctl00$LoginControl$LoginButton"));
            loginButton.Click();
            IWebElement logOut = WebDriver.getDriver.FindElement(By.Id("ctl00_ucUserActionsToolbar_lnkLogout"));
        }

        [TestCleanup]
        public void KillDriver()
        {
            WebDriver.KillDriver();
        }
    }
}

