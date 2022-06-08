using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConjuringTests.Pages
{
    public class BedroomGPageObject
    {
        private readonly IWebDriver _webDriver;
        public BedroomGPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        private IWebElement wardrobe => _webDriver.FindElement(By.XPath("//img[@onclick='hide()']"));

        private IWebElement weightInput => _webDriver.FindElement(By.XPath("//input[@type='number']"));
        private IWebElement submitButton => _webDriver.FindElement(By.XPath("//input[@onclick='fall()']"));
        private IWebElement bedroomButton => _webDriver.FindElement(By.XPath("//a[@class='linkText']"));
        private IWebElement resultsText => _webDriver.FindElement(By.XPath("//h6[@class='text-danger']"));

        public Boolean ClickWardrobeAndAlert()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//img[@onclick='hide()']")));
            wardrobe.Click();
            // Waiting for Alert
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

        public void EnterWeightAndSubmit(int weight)
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//input[@type='number']")));
            weightInput.Clear();
            weightInput.SendKeys(weight.ToString());
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//input[@onclick='fall()']")));
            submitButton.Click();
        }

        public void RepeatStepsAndEnterHighWeight(int weight)
        {
            wardrobe.Click();
            // Waiting for Alert
            WebDriverWait wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoAlertPresentException));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
            _webDriver.SwitchTo().Alert().Accept();
            weightInput.Clear();
            weightInput.SendKeys(weight.ToString());
            submitButton.Click();
        }

        public String GetWeightFormResultsText()
        {
            return resultsText.Text;
        }
    }
}
