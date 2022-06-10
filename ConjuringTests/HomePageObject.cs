using OpenQA.Selenium;
using ConjuringTests.Utils;
using OpenQA.Selenium.Support.UI;

namespace ConjuringTests.Pages
{
    public class HomePageObject
    {
        private readonly string _homepageURL = URLUtil.CreatePath("");

        private readonly IWebDriver _webDriver;

        public HomePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement PossessionButton => _webDriver.FindElement(By.ClassName("btn-danger"));

        public void GoToHomePage()
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

        public Boolean NavigateToPageAndConfirm(string searchKeyword, string subpath)
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.LinkText(searchKeyword)));
            _webDriver.FindElement(By.LinkText(searchKeyword)).Click();
            string newUrl = URLUtil.CreatePath(subpath);
            if (_webDriver.Url != newUrl)
            {
                return false;
            }
            return true;
        }
    }
}
