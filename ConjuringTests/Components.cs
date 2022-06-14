using OpenQA.Selenium;
using ConjuringTests.Utils;
using OpenQA.Selenium.Support.UI;
using ConjuringTests.Pages;
using ConjuringTests.Drivers;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace ConjuringTests.Components
{
    public class BaseComponent
    {
        private readonly IWebDriver _webDriver;

        public BaseComponent(By locator)
        {

        }

        

        public IWebElement FindElement(By locator)
        {
            return _webDriver.FindElement(locator);
        }
    }

    class Button : BaseComponent
    {
        public Button(By locator, string elementName)
        {

        }
    }
}