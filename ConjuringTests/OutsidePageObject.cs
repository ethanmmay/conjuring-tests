using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConjuringTests.Pages
{
    public class OutsidePageObject
    {
        private readonly IWebDriver _webDriver;

        public OutsidePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement crow => _webDriver.FindElement(By.XPath("//img[@onclick='possessCrow()']"));

        private IWebElement crowCounter => _webDriver.FindElement(By.XPath("//span"));

        public void Click20Crows()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//img[@onclick='possessCrow()']")));
            while (crowCounter.Text != "20")
            {
                crow.Click();
            }
        }

        public String GetCrowCount()
        {
            return crowCounter.Text;
        }
    }
}
