using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using netcore.template.util;

namespace netcore.template.Pages
{
    public class LoginPage : BasePage
    {
        public static string HomeUrl = string.Concat(BaseUrl,"/");
        By LOGIN = By.XPath("//*[@id=\"login-button\"]");
        By USERNAME = By.XPath("//*[@id=\"user-name\"]");
        By PASSWORD = By.XPath("//*[@id=\"password\"]");

        public void Visit()
        {
            Driver.WebDriver.Navigate().GoToUrl(HomePage.HomeUrl);
        }

        public void FillLoginForm(string username, string password)
        {
            SendKeys(USERNAME, username);
            SendKeys(PASSWORD, password);
            Click(LOGIN);
        }

        


    }
}