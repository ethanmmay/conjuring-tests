using OpenQA.Selenium;
using ConjuringTests.Utils;

namespace ConjuringTests.Pages
{
    public class OutsidePageObject
    {
        // Builds the expected URL for the testing site's Outside page
        private string _outsideURL = URLUtil.CreatePath("outside-b.html");

        // Instantiates a new Driver
        private readonly IWebDriver _webDriver;

        // Sets driver to one provided by OutsidePossessionStepDefinitions.cs
        public OutsidePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        // Locates image of a crow using its class name, "crow"
        private IWebElement crow => _webDriver.FindElement(By.ClassName("crow"));

        // Locates text on the page using its Id, "crowCounter"
        private IWebElement crowCounter => _webDriver.FindElement(By.Id("crowCounter"));

        // Compares the drivers current URL with the _outsideURL built earlier
        public void VerifyAtOutsidePage()
        {
            if (_webDriver.Url != _outsideURL)
            {
                // If the URLs do not match, this sets the Driver's URL to the _outsideURL built earlier
                _webDriver.Url = _outsideURL;
            }
        }

        // Clicks on the image of a crow 20 times no matter where it moves to
        public void Click20Crows()
        {
            for(int i = 1; i < 21; i++)
            {
                crow.Click();
                Thread.Sleep(1000/i);
            }
        }

        // Retrieves the crowCounter text that displays how many times the crow has been clicked
        public String GetCrowCount()
        {
            return crowCounter.Text;
        }
    }
}
