using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace NunitPoc.src.main.dotnet.common
{
     public class CommonMethods
    {

        public IWebDriver driver;

        public CommonMethods()
        {
            this.driver = new ChromeDriver(); 
        }

        [OneTimeSetUp]
        public void DriverInitialization()
        {
            Console.WriteLine("initialize driver");
            //start service method call

        }

        public void ExplicitWait(double timeInSeconds, By locator)
        {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeInSeconds));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            Thread.Sleep(3000);
        }
        public void clickWithWait(By eleToBClicked)
        {
            ExplicitWait(5, eleToBClicked);
            driver.FindElement(eleToBClicked).Click();

        }
        public void clickWithNoWait(By eleToBClicked)
        {
            driver.FindElement(eleToBClicked).Click();

        }
      
        public void driverQuit()
        {
            driver.Quit();
        }


    }
}
