using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using System;
using NunitPoc.src.main.dotnet.common;

namespace testcases 
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //
            //start video recording
            ////create extend test and setup independent driver
        }

        [Test]
        public void launchZigWheels()
        {
            NewCar nc = new NewCar();
            nc.launchSite("https://www.zigwheels.com/newcars");
            string pageTitle = "Cars in India, New Cars in 2021, New Model Prices, Offers, Image @ ZigWheels";
            nc.VerifyPageTitle(pageTitle);   
        }

        [Test]
        public void searchForCar()
        {
            string tiagoPageTitle = "Tata Tiago Price 2021, February Offers, Images, Mileage, Review, Specs.";
            NewCar nc = new NewCar();
            nc.launchSite("https://www.zigwheels.com/newcars");
            nc.EnterCarSearch();
            nc.VerifyPageTitle(tiagoPageTitle);
            nc.ClickPrice();
            string tiagoPriceTitle = "Tata Tiago Price in Hyderabad, Tiago On Road Price (February 2021)";
            nc.VerifyPageTitle(tiagoPriceTitle);
            
        }
        [TearDown]
        public void TearDown()
        {
            CommonMethods cm = new CommonMethods();
            cm.driverQuit();

        }
    }
}