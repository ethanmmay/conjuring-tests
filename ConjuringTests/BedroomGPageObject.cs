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
        private IWebElement Wardrobe => _webDriver.FindElement(By.XPath("//img[@onclick='hide()']"));

        private IWebElement WeightInput => _webDriver.FindElement(By.XPath("//input[@type='number']"));
        private IWebElement SubmitButton => _webDriver.FindElement(By.XPath("//input[@onclick='fall()']"));
        private IWebElement ResultsText => _webDriver.FindElement(By.XPath("//h6[@class='text-danger']"));

        public Boolean ClickWardrobeAndAlert()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//img[@onclick='hide()']")));
            Wardrobe.Click();
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

        public void EnterWeightAndSubmit(int weight)
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//input[@type='number']")));
            WeightInput.Clear();
            WeightInput.SendKeys(weight.ToString());
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//input[@onclick='fall()']")));
            SubmitButton.Click();
        }

        public void RepeatStepsAndEnterHighWeight(int weight)
        {
            Wardrobe.Click();
            // Waiting for Alert
            WebDriverWait wait = new(_webDriver, TimeSpan.FromSeconds(10));
            wait.IgnoreExceptionTypes(typeof(NoAlertPresentException));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
            _webDriver.SwitchTo().Alert().Accept();
            WeightInput.Clear();
            WeightInput.SendKeys(weight.ToString());
            SubmitButton.Click();
        }

        public String GetWeightFormResultsText()
        {
            String resultsText = ResultsText.Text;
            _webDriver.Quit();
            return resultsText;
        }
    }
}
