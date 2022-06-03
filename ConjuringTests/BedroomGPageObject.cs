using OpenQA.Selenium;

namespace ConjuringTests.Pages
{
    public class BedroomGPageObject
    {
        // Instantiates a new Driver
        private readonly IWebDriver _webDriver;

        // Sets driver to one provided by BedroomUnpossessedStepDefinitions.cs
        public BedroomGPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        // Locates image of a wardrobe on page using its class name, "wardrobeImage"
        private IWebElement wardrobe => _webDriver.FindElement(By.ClassName("wardrobeImage"));

        // Locates a text input field using its Id, "weightFormInput"
        private IWebElement weightInput => _webDriver.FindElement(By.Id("weightFormInput"));

        // Locates a button for submitting the text using its Id, "weightFormButton"
        private IWebElement submitButton => _webDriver.FindElement(By.Id("weightFormButton"));

        // Locates a link to the BedroomG page using the linktext, "Bedroom"
        private IWebElement bedroomButton => _webDriver.FindElement(By.LinkText("Bedroom"));

        // Locates the results text after submitting a weight using its bootstrap class name, "text-danger"
        private IWebElement resultsText => _webDriver.FindElement(By.ClassName("text-danger"));

        // Clicks on the image of a Wardrobe, then confirms the alert that appears
        public void ClickWardrobeAndAlert()
        {
            Thread.Sleep(1000);
            wardrobe.Click();
            Thread.Sleep(1000);
            _webDriver.SwitchTo().Alert().Accept();
        }

        // Enters a weight of 80 into text input field and clicks submit button
        public void EnterWeightAndSubmit(int weight)
        {
            weightInput.Clear();
            weightInput.SendKeys(weight.ToString());
            Thread.Sleep(3000);
            submitButton.Click();
        }

        // Clicks on a link that returns the driver to the BedroomG Page
        // Clicks on the image of a Wardrobe, then confirms the alert that appears
        // Enters a weight of 120 into text input field and clicks submit button
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

        // Retrieves the results text that appears after submitting a weight above 100
        public String GetWeightFormResultsText()
        {
            return resultsText.Text;
        }
    }
}
