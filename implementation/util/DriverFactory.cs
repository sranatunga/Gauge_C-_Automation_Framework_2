using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using WebDriverManager.DriverConfigs.Impl;

namespace netcore.template.util
{
    public class DriverFactory
    {
        public static IWebDriver GetDriver(IWebDriver driver)
        {
            IWebDriver _driver = driver;
            var browser = Environment.GetEnvironmentVariable("BROWSER");
            var webDriverPath = Environment.GetEnvironmentVariable("WEB_DRIVER_PATH");
            Console.WriteLine(browser);

            if (browser == null)
            {
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                _driver = new ChromeDriver();
                Pages.PageFactory.init();
                return _driver;
            } else {
           
                switch (browser)
                {
                    case "chrome":
                        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                        _driver = new ChromeDriver();
                        Pages.PageFactory.init();
                        return _driver;

                    case "headless":
                        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                        ChromeOptions options = new ChromeOptions();
                        options.AddArguments("--headless"); 
                        _driver = new ChromeDriver(options);
                        Pages.PageFactory.init();
                        return _driver;

                    case "firefox":
                        new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                        _driver = new FirefoxDriver();
                        Pages.PageFactory.init();
                        return _driver;

                    case "edge":
                        new WebDriverManager.DriverManager().SetUpDriver(new InternetExplorerConfig());
                        _driver = new InternetExplorerDriver();
                        Pages.PageFactory.init();
                        return _driver;

                    default: 
                        new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                        _driver = new ChromeDriver();
                        Pages.PageFactory.init();
                        return _driver;                    
                }
            }            
        }
    }
}
