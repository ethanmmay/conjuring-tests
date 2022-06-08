using ConjuringTests.Pages;
using ConjuringTests.Drivers;
using FluentAssertions;
using TechTalk.SpecFlow;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class BedroomUnpossessedStepDefinitions
    {
        private readonly HomePageObject _homePage;
        private readonly BedroomGPageObject _bedroomGPage;

        public BedroomUnpossessedStepDefinitions(BrowserDriver browserDriver)
        {
            _homePage = new HomePageObject(browserDriver.Current);
            _bedroomGPage = new BedroomGPageObject(browserDriver.Current);
        }

        [Given(@"I am on conjuring site going towards BedroomG")]
        public void GivenIAmOnConjuringSite3()
        {
            _homePage.VerifyAtHomePage();
        }

        [When(@"I click BedroomG")]
        public void WhenIClickBedroomG()
        {
            _homePage.NavigateToPage("Bedroom", "bedroom-g.html").Should().BeTrue();
        }

        [When(@"I click on wardrobe and alert")]
        public void WhenIClickOnWardrobeAndAlert()
        {
            Boolean alertClicked = _bedroomGPage.ClickWardrobeAndAlert();
            alertClicked.Should().BeTrue();
        }

        [When(@"I enter low weight and submit")]
        public void WhenIEnterLowWeightAndSubmit()
        {
            _bedroomGPage.EnterWeightAndSubmit(80);
        }

        [When(@"I repeat steps and enter high weight")]
        public void WhenIRepeatStepsAndEnterHighWeight()
        {
            _homePage.VerifyAtHomePage();
            _homePage.NavigateToPage("Bedroom", "bedroom-g.html").Should().BeTrue();
            _bedroomGPage.RepeatStepsAndEnterHighWeight(120);
        }

        [Then(@"I fall through the house")]
        public void ThenIFallThroughTheHouse()
        {
            String resultsText = _bedroomGPage.GetWeightFormResultsText();
            resultsText.Should().Contain("Suddenly ");
        }
    }
}
