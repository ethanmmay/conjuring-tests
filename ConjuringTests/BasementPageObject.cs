using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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

        // Locates image of piano on page using its class name, "pianoImage"
        private IWebElement PianoImage => _webDriver.FindElement(By.ClassName("pianoImage"));

        // Moves position of the page to focus on the image of a piano
        public void ScrollDown()
        {
            var piano = _webDriver.FindElement(By.ClassName("pianoImage"));
            Actions actions = new(_webDriver); // This is the same as: Actions actions = new Actions(_webDriver);
            actions.MoveToElement(piano);
            actions.Perform();
        }

        // Clicks on the image of a piano
        public void ClickPiano()
        {
            PianoImage.Click();
        }

        // Accepts the alert that appears after clicking on the image of a piano
        public void VerifyPianoAlertAppears()
        {
            Thread.Sleep(3000);
            _webDriver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }
    }
}
