using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace Selenium_Grid
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver _driver;
        [TestMethod]
        public void TestMethod1()
        {

            DesiredCapabilities caps = new DesiredCapabilities();
            caps.SetCapability(CapabilityType.BrowserName, "chrome");

            _driver = new RemoteWebDriver(new Uri("http://192.168.0.5:4444/wd/hub"), caps);
            _driver.Navigate().GoToUrl("http://www.espn.com");
            _driver.Close();

        }
    }
}
