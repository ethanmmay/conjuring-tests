using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConjuringTests.Drivers;
using OpenQA.Selenium;

namespace ConjuringTests.Pages
{
    public class HomePageObject
    {
        private const string HomePageUrl = "https://ethanmmay.github.io/conjuring-site";

        private readonly IWebDriver _webDriver;

        public const int DefaultWaitInSeconds = 5;

        public HomePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement PossessionButton => _webDriver.FindElement(By.Id("possess-button"));
        private IWebElement BasementLink => _webDriver.FindElement(By.LinkText("basement-b.html"));

    }
}
