using System;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium.Support.PageObjects;
using netcore.template.util;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace netcore.template.Pages
{
    public abstract class BasePage //  "BasePage" class is a abstract class(Abstract class used to define a base class.A base class is a class has the most basic definition of a particular requirement. )
    {    
        public IWebDriver driver;

        protected static readonly string BaseUrl = Environment.GetEnvironmentVariable("APP_ENDPOINT");
        protected static readonly string AdminUrl = string.Format("{0}admin/", BaseUrl);

        protected BasePage()
        {
            //PageFactory.InitElements(Driver.WebDriver, this);
            this.driver = Driver.WebDriver;
        }

        public IWebElement GetElement(string name)
        {
            var field = GetType().GetField(name, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
            return field == null ? null : field.GetValue(this) as IWebElement;
        }

        protected static void ClearAndSetValue(IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }
        protected void SendKeys(By locator, string value)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            Driver.WebDriver.FindElement(locator).Clear();
            Driver.WebDriver.FindElement(locator).SendKeys(value);
        }

        protected void SendKeyTab(By locator)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            Driver.WebDriver.FindElement(locator).SendKeys(Keys.Tab);
        }

        protected void SendKeyEscape()
        {
            //new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(locator));
            //Driver.WebDriver.FindElement(locator).SendKeys(Keys.Escape);

            Actions action = new Actions(Driver.WebDriver);
            action.SendKeys(Keys.Escape);
        }

        protected void SendKeyEnter(By locator)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            Driver.WebDriver.FindElement(locator).SendKeys(Keys.Enter);
        }

        protected void Click(By locator)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            Driver.WebDriver.FindElement(locator).Click();
        }

        protected string GetText(By locator)
        {            
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            string text = Driver.WebDriver.FindElement(locator).Text;
            return text;
        }
        
        protected string GetAttribute(By locator, String attributeName)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));

            return Driver.WebDriver.FindElement(locator).GetAttribute(attributeName);
        }

        protected bool IsDisplayed(By locator)
        {
            bool isLocatorDisplayed;

             try
            {
                new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                isLocatorDisplayed = Driver.WebDriver.FindElement(locator).Displayed;

            }
            catch (NoSuchElementException)
            {
                isLocatorDisplayed = false;
            }

            return isLocatorDisplayed;


        }
        protected string GetAttributeValue(By locator)
        {
            return GetAttribute(locator, "value");
        }

        protected void MoveTo(By locator)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            IWebElement element = Driver.WebDriver.FindElement(locator);

            Actions actions = new Actions(Driver.WebDriver);
            actions.MoveToElement(element);
            actions.Perform();
        }

        protected void SwitchToTopWindow()
        {
            foreach(string handle in Driver.WebDriver.WindowHandles)
            {
                Driver.WebDriver.SwitchTo().Window(handle);
            }

            Driver.WebDriver.Manage().Window.Maximize();
        }

        protected void SwitchToFrame(int index)
        {
            Driver.WebDriver.SwitchTo().Frame(index);
        }

        protected void SwitchToFrame(By locator)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.FrameToBeAvailableAndSwitchToIt(locator));
        }
        protected void SwitchToDefaultContent()
        {
            Driver.WebDriver.SwitchTo().DefaultContent();
        }

        protected void Select(By locator, String visibleText)
        {
            new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            SelectElement select = new SelectElement(Driver.WebDriver.FindElement(locator));

            try
            {
                select.SelectByText(visibleText);
            }
            catch (NoSuchElementException)
            {
                // Wait for 5 seconds and try
                System.Threading.Thread.Sleep(5000);
                select.SelectByText(visibleText);
            }

            catch (StaleElementReferenceException)
            {
                // Wait for 5 seconds and try
                System.Threading.Thread.Sleep(5000);
                select.SelectByText(visibleText);
            }
        }

        protected bool IsChecked(By locator)
        {
            //new WebDriverWait(Driver.WebDriver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            bool status = Driver.WebDriver.FindElement(locator).Selected;
            return status ;
        }

        protected bool IsVisible(By locator)
        {
            bool visibility = Driver.WebDriver.FindElement(locator).Displayed;
            return visibility ;
        }        
    }
}