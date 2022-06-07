using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConjuringTests.Pages
{
    public class BedroomBPageObject
    {
        // Instantiates a new Driver
        private readonly IWebDriver _webDriver;

        // Sets driver to one provided by BedroomPossessionStepDefinitions.cs
        public BedroomBPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        // Locates range input using it's input tag and it's attribute, "type"
        private IWebElement slider => _webDriver.FindElement(By.XPath("//input[@type='range']"));

        // Sends arrow key inputs to the slider to raise it to 5 and lower it back down to 0
        public void RaiseAndLowerSlider()
        {
            // Waits until the slider is loaded
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

        // Retrieves the value (0-5) of the slider input
        public String GetSliderValue()
        {
            return slider.GetAttribute("value");
        }
    }
}
