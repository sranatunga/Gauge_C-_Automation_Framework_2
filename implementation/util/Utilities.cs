using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace netcore.template.util
{
    public class Utilities
    {
        public static string DatePicker(){
            DateTime now = DateTime.Now;
            string date = now.ToString("ddMMyyyyhhmmss");
            return date;
        }
    }
}
