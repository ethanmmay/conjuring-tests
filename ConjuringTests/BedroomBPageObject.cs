using OpenQA.Selenium;

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

        // Locates range input using it's assigned name, "wardrobeBump"
        private IWebElement slider => _webDriver.FindElement(By.Name("wardrobeBump"));

        // Sends arrow key inputs to the slider to raise it to 5 and lower it back down to 0
        public void RaiseAndLowerSlider()
        {
            for(int i = 0; i < 5; i++)
            {
                slider.SendKeys(Keys.ArrowRight);
                Thread.Sleep(100);
            }
            for (int i = 0; i < 5; i++)
            {
                slider.SendKeys(Keys.ArrowLeft);
                Thread.Sleep(100);
            }
        }

        // Retrieves the value (0-5) of the slider input
        public String GetSliderValue()
        {
            return slider.GetAttribute("value");
        }
    }
}
