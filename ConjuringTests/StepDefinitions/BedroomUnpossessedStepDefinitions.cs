using ConjuringTests.Pages;
using ConjuringTests.Drivers;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class BedroomUnpossessedStepDefinitions
    {
        // Instantiating Necessary PageObjects for test methods
        private readonly HomePageObject _homePage;
        private readonly BedroomGPageObject _bedroomGPage;

        // Retrieving PageObject methods using current Driver
        public BedroomUnpossessedStepDefinitions(BrowserDriver browserDriver)
        {
            _homePage = new HomePageObject(browserDriver.Current);
            _bedroomGPage = new BedroomGPageObject(browserDriver.Current);
        }

        // Verifying driver's location at test site
        [Given(@"I am on conjuring site going towards BedroomG")]
        public void GivenIAmOnConjuringSite3()
        {
            _homePage.VerifyAtHomePage();
        }

        // This method is testing an "Unpossessed" section of the site,
        // Therefore, the test doesn't click the "Possession" button to alter the links

        // Navigating to BedroomG Page
        [When(@"I click BedroomG")]
        public void WhenIClickBedroomG()
        {
            _homePage.NavigateToBedroomG();
        }

        // Clicking on image to activate alert, then confirming alert
        [When(@"I click on wardrobe and alert")]
        public void WhenIClickOnWardrobeAndAlert()
        {
            _bedroomGPage.ClickWardrobeAndAlert();
        }

        // Entering a weight of 80 into input and submitting
        [When(@"I enter low weight and submit")]
        public void WhenIEnterLowWeightAndSubmit()
        {
            _bedroomGPage.EnterWeightAndSubmit(80);
        }

        // Returns to BedroomG Page then clicks the image, confirms the alert and
        // enters a weight of 120 into input then clicks Submit button
        [When(@"I repeat steps and enter high weight")]
        public void WhenIRepeatStepsAndEnterHighWeight()
        {
            _bedroomGPage.RepeatStepsAndEnterHighWeight(120);
        }

        // Verifies that the correct text for a weight above 100 appears
        [Then(@"I fall through the house")]
        public void ThenIFallThroughTheHouse()
        {
            String resultsText = _bedroomGPage.GetWeightFormResultsText();
            resultsText.Should().Contain("Suddenly ");
        }
    }
}
