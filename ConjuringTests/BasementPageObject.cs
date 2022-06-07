using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
namespace ConjuringTests.Pages
{
    public class BasementPageObject
    {
        // Instantiates a new Driver
        private readonly IWebDriver _webDriver;

        // Sets driver to one provided by BasementPossessionStepDefinitions.cs
        public BasementPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        // Locates image of piano on page using it's img tag and it's onclick function, "piano(2)"
        private IWebElement PianoImage => _webDriver.FindElement(By.XPath("//img[@onclick='piano(2)']"));

        // Moves position of the page to focus on the image of a piano
        public void ScrollDown()
        {
            // Waits until the piano image is loaded
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//img[@onclick='piano(2)']")));
            // Scrolls screen down to piano image
            new Actions(_webDriver).MoveToElement(PianoImage).Perform();
        }

        // Clicks on the image of a piano
        public void ClickPiano()
        {
            PianoImage.Click();
        }

        // Waits to accept the alert that appears after clicking on the image of a piano
        public Boolean VerifyPianoAlertAppears()
        {
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoAlertPresentException));
            IAlert alert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
            if (alert != null)
            {
                _webDriver.SwitchTo().Alert().Accept();
                return true;
            }
            return false;
        }
    }
}
