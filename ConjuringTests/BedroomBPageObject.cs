using OpenQA.Selenium;

namespace ConjuringTests.Pages
{
    public class BedroomBPageObject
    {
        private readonly IWebDriver _webDriver;

        public BedroomBPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement slider => _webDriver.FindElement(By.Name("wardrobeBump"));
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

        public String GetSliderValue()
        {
            return slider.GetAttribute("value");
        }
    }
}
