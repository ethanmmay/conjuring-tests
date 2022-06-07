using ConjuringTests.Pages;
using ConjuringTests.Drivers;
using FluentAssertions;
using TechTalk.SpecFlow;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class OutsidePossessionStepDefinitions
    {
        // Instantiating Necessary PageObjects for test methods
        private readonly HomePageObject _homePage;
        private readonly OutsidePageObject _outsidePage;

        // Retrieving PageObject methods using current Driver
        public OutsidePossessionStepDefinitions(BrowserDriver browserDriver)
        {
            _homePage = new HomePageObject(browserDriver.Current);
            _outsidePage = new OutsidePageObject(browserDriver.Current);
        }

        // Verifying driver's location at test site
        [Given(@"I am on conjuring site going towards Outside")]
        public void GivenIAmOnConjuringSite2()
        {
            _homePage.VerifyAtHomePage();
        }

        // Clicking "Possession" button to alter links
        [When(@"I click possession for going Outside")]
        public void WhenIClickPossesion2()
        {
            _homePage.ClickPossessionButton();
        }

        // Navigating to OutsideB Page
        [When(@"I click Outside")]
        public void WhenIClickOutside()
        {
            _homePage.NavigateToOutside();
        }

        // Clicks the image of a crow 20 times despite it moving on the page
        [When(@"I click 20 crows")]
        public void WhenIClick20Crows()
        {
            _outsidePage.Click20Crows();
        }

        // Verifies that the counter for how many times the crow has been clicked is at 20
        [Then(@"the crows possessed is 20")]
        public void ThenTheCrowsPossessedIs20()
        {
            String crowCount = _outsidePage.GetCrowCount();
            crowCount.Should().Be("20");
        }
    }
}
