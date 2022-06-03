using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ConjuringTests.Pages
{
    public class BasementPageObject
    {
        private readonly IWebDriver _webDriver;

        public BasementPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement PianoImage => _webDriver.FindElement(By.ClassName("pianoImage"));

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
            Thread.Sleep(3000);
            _webDriver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }
    }
}
