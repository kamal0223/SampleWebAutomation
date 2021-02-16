using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using NunitPoc.src.main.dotnet.common;
using NUnit.Framework;

//using OpenQA.seleniumex

namespace testcases
{
    public class NewCar: CommonMethods
    {
        IWebDriver driver;
        public NewCar()
        {
            this.driver = base.driver;
        }
        public void launchSite(string site)
        {
            driver.Navigate().GoToUrl(site);
            
        }

        public void VerifyPageTitle(string expectedTitle)
        {
            
            By eleInPage = By.Name("bysearch");
            ExplicitWait(4, eleInPage);
            Assert.That(driver.Title, Is.EqualTo(expectedTitle));
        }

        public void EnterCarSearch()
        {
            By googleSearchLocator = By.Name("bysearch");
            Thread.Sleep(3000);
            driver.FindElement(googleSearchLocator).SendKeys("tiago");
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Enter);
        }

        public void ClickPrice()
        {
            By onRoadPrice = By.XPath("//a[contains(@title,'On road price')]");
            Thread.Sleep(3000);
            clickWithNoWait(onRoadPrice);
        }
    }
}