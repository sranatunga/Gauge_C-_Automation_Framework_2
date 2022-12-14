using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace netcore.template.util
{
    public class Driver
    {
        // Holds the WebDriver instance
        private static IWebDriver _driver;               

        [BeforeSuite]
        public void Initialize()
        {
            _driver = DriverFactory.GetDriver(_driver);
            _driver.Manage().Window.Maximize();
            Console.WriteLine("Initialized");
        }

        [AfterSuite]
        public void Cleanup()
        {
            _driver.Quit();
        }

        public static IWebDriver WebDriver
        {
            get { return _driver; }
        }
    }
}
