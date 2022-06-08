using ConjuringTests.Pages;
using ConjuringTests.Drivers;
using TechTalk.SpecFlow;
using FluentAssertions;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class BasementPossessionStepDefinitions
    {
        private readonly HomePageObject _homePage;
        private readonly BasementPageObject _basementPage;

        public BasementPossessionStepDefinitions(BrowserDriver browserDriver)
        {
            _homePage = new HomePageObject(browserDriver.Current);
            _basementPage = new BasementPageObject(browserDriver.Current);
        }

        [Given(@"I am on conjuring site going towards Basement")]
        public void GivenIAmOnConjuringSite()
        {
            _homePage.VerifyAtHomePage();
        }

        [When(@"I click possession for going to Basement")]
        public void WhenIClickPossesion()
        {
            _homePage.ClickPossessionButton();
        }

        [When(@"I click Basement")]
        public void WhenIClickBasement()
        {
            _homePage.NavigateToPage("Basement", "basement-b.html").Should().BeTrue();
        }

        [When(@"I scroll down")]
        public void WhenIScrollDown()
        {
            _basementPage.ScrollDown();
        }

        [When(@"I click on the piano")]
        public void WhenIClickOnThePiano()
        {
            _basementPage.ClickPiano();
        }

        [Then(@"the piano alert appears")]
        public void ThenThePianoAlertAppears()
        {
            Boolean alertAppears = _basementPage.VerifyPianoAlertAppears();
            alertAppears.Should().BeTrue();
        }
    }
}
