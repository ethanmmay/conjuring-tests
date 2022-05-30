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

        private IWebElement PossessionButton => _webDriver.FindElement(By.ClassName("possessButton"));
        private IWebElement BasementLink => _webDriver.FindElement(By.LinkText("Basement"));
        private IWebElement OutsideLink => _webDriver.FindElement(By.LinkText("Outside"));
        private IWebElement BedroomLink => _webDriver.FindElement(By.LinkText("Bedroom"));

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

        public void NavigateToBedroomG()
        {
            BedroomLink.Click();
        }

        public void NavigateToBedroomB()
        {
            BedroomLink.Click();
        }
    }
}
