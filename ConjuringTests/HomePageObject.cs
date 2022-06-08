using OpenQA.Selenium;
using ConjuringTests.Utils;

namespace ConjuringTests.Pages
{
    public class HomePageObject
    {
        private string _homepageURL = URLUtil.CreatePath("");

        private readonly IWebDriver _webDriver;

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
            if (_webDriver.Url != _homepageURL)
            {
                _webDriver.Url = _homepageURL;
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
