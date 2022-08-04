using System;
using Gauge.CSharp.Lib.Attribute;
using netcore.template.Pages;
using netcore.template.util;
using NUnit.Framework;

namespace netcore.template
{
    public class LoginSpec
    {
        [Step("Login as <username> using <password>")]
        public void LoginAs(string username, string password)
        {
            PageFactory.LoginPage.FillLoginForm(username, password);
            
        }

        [Step("Go to login page")]
        public void GoToLoginPage()
        {   
            PageFactory.LoginPage.Visit();
        }

    }
}