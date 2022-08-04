/*
Author- Oshani Kaushalya
Date- 24/12/19
*/
using Gauge.CSharp.Lib.Attribute;


namespace netcore.template.Pages
{
    public class PageFactory 
    {
        //public static IWebDriver driver;

        public static HomePage HomePage;
        public static LoginPage LoginPage;

        [BeforeSuite]
        public static void init()
        {
            HomePage = new HomePage();
            LoginPage = new LoginPage();
        }

    }
}