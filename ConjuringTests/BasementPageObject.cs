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
    public class BasementPageObject
    {
        private const string BasementUrl = "https://ethanmmay.github.io/conjuring-site/basement-b";

        private readonly IWebDriver _webDriver;

        public const int DefaultWaitInSeconds = 5;

        public BasementPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement PianoImage => _webDriver.FindElement(By.ClassName("pianoImage"));

        public void VerifyAtBasementPage()
        {
            if (_webDriver.Url != BasementUrl)
            {
                _webDriver.Url = BasementUrl;
            }
        }

        public void ScrollDown()
        {
            var piano = _webDriver.FindElement(By.ClassName("pianoImage"));
            Actions actions = new(_webDriver); // This is just: Actions actions = new Actions(_webDriver);
            actions.MoveToElement(piano);
            actions.Perform();
        }

        public void ClickPiano()
        {
            PianoImage.Click();
        }

        public void VerifyPianoAlertAppears()
        {
            Thread.Sleep(5000);
            _webDriver.SwitchTo().Alert().Accept();
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
