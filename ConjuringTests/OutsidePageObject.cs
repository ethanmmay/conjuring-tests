using OpenQA.Selenium;
using ConjuringTests.Utils;

namespace ConjuringTests.Pages
{
    public class OutsidePageObject
    {
        private string _outsideURL = URLUtil.CreatePath("outside-b.html");

        private readonly IWebDriver _webDriver;

        public OutsidePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement crow => _webDriver.FindElement(By.ClassName("crow"));

        private IWebElement crowCounter => _webDriver.FindElement(By.Id("crowCounter"));

        public void VerifyAtOutsidePage()
        {
            if (_webDriver.Url != _outsideURL)
            {
                _webDriver.Url = _outsideURL;
            }
        }

        public void Click20Crows()
        {
            for(int i = 1; i < 21; i++)
            {
                crow.Click();
                Thread.Sleep(1000/i);
            }
        }

        public String GetCrowCount()
        {
            return crowCounter.Text;
        }
    }
}
