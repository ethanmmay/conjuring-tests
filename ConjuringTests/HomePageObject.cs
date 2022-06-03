using OpenQA.Selenium;
using ConjuringTests.URLUtil;

namespace ConjuringTests.Pages
{
    public class HomePageObject
    {
        // Builds the expected URL for the testing site homepage
        private string _homepageURL = CreatePath("");

        // Instantiates a new Driver
        private readonly IWebDriver _webDriver;

        // Sets driver to one provided by multiple StepDefinitions files
        public HomePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        // Locates a button that switches page content using its class name, "possessButton"
        private IWebElement PossessionButton => _webDriver.FindElement(By.ClassName("possessButton"));

        // Locates a link to the Basement page using the linktext, "Basement"
        private IWebElement BasementLink => _webDriver.FindElement(By.LinkText("Basement"));
        
        // Locates a link to the Outside page using the linktext, "Outside"
        private IWebElement OutsideLink => _webDriver.FindElement(By.LinkText("Outside"));
        
        // Locates a link to the Bedroom page using the linktext, "Bedroom"
        private IWebElement BedroomLink => _webDriver.FindElement(By.LinkText("Bedroom"));

        // Compares the drivers current URL with the _homepageURL built earlier
        public void VerifyAtHomePage()
        {
            if (_webDriver.Url != _homepageURL)
            {
                // If the URLs do not match, this sets the Driver's URL to the _homepageURL built earlier
                _webDriver.Url = _homepageURL;
            }
        }

        // Clicks on the "Possession" button to switch page content
        public void ClickPossessionButton()
        {
            PossessionButton.Click();
        }

        // Clicks on the Basement link to navigate to the Basement page
        public void NavigateToBasement()
        {
            BasementLink.Click();
        }

        // Clicks on the Outside link to navigate to the Outside page
        public void NavigateToOutside()
        {
            OutsideLink.Click();
        }

        // Clicks on the Bedroom link to navigate to the Basement page
        // This method is only used when the "Possession" button HAS NOT been clicked
        public void NavigateToBedroomG()
        {
            BedroomLink.Click();
        }

        // Clicks on the Bedroom link to navigate to the Basement page
        // This method is only used when the "Possession" button HAS been clicked
        public void NavigateToBedroomB()
        {
            BedroomLink.Click();
        }
    }
}
