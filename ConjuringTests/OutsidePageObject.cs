using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConjuringTests.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace ConjuringTests.Pages
{
    public class OutsidePageObject
    {
        private const string OutsideUrl = "https://ethanmmay.github.io/conjuring-site/outside-b";

        private readonly IWebDriver _webDriver;

        public const int DefaultWaitInSeconds = 5;

        public OutsidePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement crow => _webDriver.FindElement(By.ClassName("crow"));
        private IWebElement crowCounter => _webDriver.FindElement(By.Id("crowCounter"));

        public void VerifyAtOutsidePage()
        {
            if (_webDriver.Url != OutsideUrl)
            {
                _webDriver.Url = OutsideUrl;
            }
        }

        public void Click20Crows()
        {
            for(int i = 1; i < 21; i++)
            {
                crow.Click();
                Thread.Sleep(1000/i);
            }
        }

        public String GetCrowCount()
        {
            return crowCounter.Text;
        }
    }
}
