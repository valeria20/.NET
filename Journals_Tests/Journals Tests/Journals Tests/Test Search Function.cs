using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Journals_Tests
{
    [TestClass]
    class Test_Search_Function
    {
        [TestMethod]
        [Test, TestCaseSource("TextToSearchAndTitle")]
        public void TestSearchField(string textToSearch, string expectedTitle)
        {
            WebDriver.getDriver.Navigate().GoToUrl("http://journals.lww.com/");

            IWebElement searchField = WebDriver.getDriver.FindElement(By.Name("ctl00$SearchBox$txtKeywords"));
            searchField.SendKeys(textToSearch);

            IWebElement searchButton = WebDriver.getDriver.FindElement(By.Id("btnGlobalSearchMagnifier"));
            searchButton.Click();
  
            string actualTitle = WebDriver.getDriver.Title;  
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedTitle, actualTitle);
            WebDriver.getDriver.Navigate().GoToUrl("http://journals.lww.com/");

        }

     static object[][] TextToSearchAndTitle = {
       new object[] {"jacpt", "Search Results"},
       new object[] {"wlejfnow932e", "Search Results"},
       new object[] {"", "LWW Journals - Beginning with A"}
    };

    }
}
