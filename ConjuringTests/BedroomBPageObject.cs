using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConjuringTests.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace ConjuringTests.Pages
{
    public class BedroomBPageObject
    {
        private readonly IWebDriver _webDriver;

        public const int DefaultWaitInSeconds = 5;

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
