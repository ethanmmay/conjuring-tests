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

        private IWebElement Slider => _webDriver.FindElement(By.XPath("//input[@type='range']"));

        public void RaiseAndLowerSlider()
        {
            new WebDriverWait(_webDriver, TimeSpan.FromSeconds(10)).Until(e => e.FindElement(By.XPath("//input[@type='range']")));
            while (Slider.GetAttribute("value") != "5") 
            {
                Slider.SendKeys(Keys.ArrowRight);
            }
            while (Slider.GetAttribute("value") != "0")
            {
                Slider.SendKeys(Keys.ArrowLeft);
            }
        }

        public String GetSliderValue()
        {
            return Slider.GetAttribute("value");
        }
    }
}
