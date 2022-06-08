using OpenQA.Selenium;
using ConjuringTests.Utils;
using OpenQA.Selenium.Support.UI;
using ConjuringTests.Pages;
using ConjuringTests.Drivers;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace ConjuringTests.Components
{
    public class Component
    {
        private readonly IWebDriver _webDriver;

        public Component(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public IWebElement FindElement(By locator)
        {
            return _webDriver.FindElement(locator);
        }
    }
}