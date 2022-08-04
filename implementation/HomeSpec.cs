using System;
using Gauge.CSharp.Lib.Attribute;
using netcore.template.Pages;
using netcore.template.util;
using NUnit.Framework;

namespace netcore.template
{
    public class HomeSpec
    {
        [Step("Verify title <title>")]
        public void VerifyTitle(string title){
            Assert.AreEqual(title,PageFactory.HomePage.GetTitle());
        }
    }
}