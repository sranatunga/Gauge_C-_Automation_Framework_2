using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using netcore.template.util;

namespace netcore.template.Pages
{
    public class HomePage : BasePage
    {
        public static string HomeUrl = string.Concat(BaseUrl,"/");
        By TITLE = By.XPath("//*[@class=\"title\"]");

        public string GetTitle()
        {
            return GetText(TITLE);
        }

        


    }
}