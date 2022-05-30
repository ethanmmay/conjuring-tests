using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConjuringTests.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConjuringTests.Pages
{
    public class HomePageObject
    {
        private const string HomePageUrl = "https://ethanmmay.github.io/conjuring-site";
        private const string BasementUrl = "https://ethanmmay.github.io/conjuring-site/basement-b";

        private readonly IWebDriver _webDriver;

        public const int DefaultWaitInSeconds = 5;

        public HomePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private string CurrentLocation => _webDriver.Url;
        private IWebElement PossessionButton => _webDriver.FindElement(By.ClassName("possessButton"));
        private IWebElement BasementLink => _webDriver.FindElement(By.LinkText("Basement"));
        private IWebElement OutsideLink => _webDriver.FindElement(By.LinkText("Outside"));

        public void VerifyAtHomePage()
        {
            if (_webDriver.Url != HomePageUrl)
            {
                _webDriver.Url = HomePageUrl;
            }
        }

        public void ClickPossessionButton()
        {
            PossessionButton.Click();
        }

        public void NavigateToBasement()
        {
            BasementLink.Click();
        }

        public void NavigateToOutside()
        {
            OutsideLink.Click();
        }

        public void VerifyAtBasement()
        {
            if (_webDriver.Url != BasementUrl)
            {
                _webDriver.Url = BasementUrl;
            }
        }

        private T WaitUntil<T>(Func<T> getResult, Func<T, bool> isResultAccepted) where T : class
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(DefaultWaitInSeconds));
#pragma warning disable CS8603 // Possible null reference return.
            return wait.Until(driver =>
            {
                var result = getResult();
                if (!isResultAccepted(result))
                    return default;

                return result;
            });
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
