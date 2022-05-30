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
        //private IWebElement 

        public void ClickWardrobeAndAlert()
        {
            wardrobe.Click();
            _webDriver.SwitchTo().Alert().Accept();
        }

        public void EnterWeightAndSubmit(int weight)
        {
            weightInput.Clear();
            weightInput.SendKeys(weight.ToString());
            submitButton.Click();
        }

        public void RepeatStepsAndEnterHighWeight(int weight)
        {

        }




    }
}
