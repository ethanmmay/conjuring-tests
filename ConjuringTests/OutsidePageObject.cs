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

        private IWebElement Crow => _webDriver.FindElement(By.XPath("//img[@onclick='possessCrow()']"));

        private IWebElement CrowCounter => _webDriver.FindElement(By.XPath("//span"));

        public void Click20Crows()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//img[@onclick='possessCrow()']")));
            while (CrowCounter.Text != "20")
            {
                Crow.Click();
            }
        }

        public String GetCrowCount()
        {
            return CrowCounter.Text;
        }
    }
}
