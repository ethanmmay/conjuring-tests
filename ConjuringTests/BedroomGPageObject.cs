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
    public class BedroomGPageObject
    {
        private readonly IWebDriver _webDriver;

        public const int DefaultWaitInSeconds = 5;

        public BedroomGPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        private IWebElement wardrobe => _webDriver.FindElement(By.ClassName("wardrobeImage"));
        private IWebElement weightInput => _webDriver.FindElement(By.Id("weightFormInput"));
        private IWebElement submitButton => _webDriver.FindElement(By.Id("weightFormButton"));
        private IWebElement bedroomButton => _webDriver.FindElement(By.LinkText("Bedroom"));

        public void ClickWardrobeAndAlert()
        {
            Thread.Sleep(1000);
            wardrobe.Click();
            Thread.Sleep(1000);
            _webDriver.SwitchTo().Alert().Accept();
        }

        public void EnterWeightAndSubmit(int weight)
        {
            weightInput.Clear();
            weightInput.SendKeys(weight.ToString());
            Thread.Sleep(3000);
            submitButton.Click();
        }

        public void RepeatStepsAndEnterHighWeight(int weight)
        {
            Thread.Sleep(1000);
            bedroomButton.Click();
            wardrobe.Click();
            Thread.Sleep(500);
            _webDriver.SwitchTo().Alert().Accept();
            weightInput.Clear();
            weightInput.SendKeys(weight.ToString());
            Thread.Sleep(1000);
            submitButton.Click();
            Thread.Sleep(3000);
        }




    }
}
