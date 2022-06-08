using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConjuringTests.Pages
{
    public class BedroomBPageObject
    {
        private readonly IWebDriver _webDriver;

        public BedroomBPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement slider => _webDriver.FindElement(By.XPath("//input[@type='range']"));

        public void RaiseAndLowerSlider()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//input[@type='range']")));
            while (slider.GetAttribute("value") != "5") 
            {
                slider.SendKeys(Keys.ArrowRight);
            }
            while (slider.GetAttribute("value") != "0")
            {
                slider.SendKeys(Keys.ArrowLeft);
            }
        }

        public String GetSliderValue()
        {
            return slider.GetAttribute("value");
        }
    }
}
