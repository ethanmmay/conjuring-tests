using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
namespace ConjuringTests.Pages
{
    public class BasementPageObject
    {
        private readonly IWebDriver _webDriver;

        public BasementPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        private IWebElement PianoImage => _webDriver.FindElement(By.XPath("//img[@onclick='piano(2)']"));

        public void ScrollDown()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//img[@onclick='piano(2)']")));
            new Actions(_webDriver).MoveToElement(PianoImage).Perform();
        }

        public void ClickPiano()
        {
            PianoImage.Click();
        }

        public Boolean ClickPianoAlert()
        {
            // Waiting for Alert
            WebDriverWait wait = new(_webDriver, TimeSpan.FromSeconds(10));
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
