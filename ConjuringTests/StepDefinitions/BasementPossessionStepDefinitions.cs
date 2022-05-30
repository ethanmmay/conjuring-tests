using ConjuringTests.Pages;
using ConjuringTests.Drivers;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class BasementPossessionStepDefinitions
    {
        private readonly HomePageObject _homePageObject;
        private readonly BasementPageObject _basementPageObject;

        public BasementPossessionStepDefinitions(BrowserDriver browserDriver)
        {
            _homePageObject = new HomePageObject(browserDriver.Current);
            _basementPageObject = new BasementPageObject(browserDriver.Current);
        }

        [Given(@"I am on conjuring site going towards Basement")]
        public void GivenIAmOnConjuringSite()
        {
            _homePageObject.VerifyAtHomePage();
        }

        [When(@"I click possession for going to Basement")]
        public void WhenIClickPossesion()
        {
            _homePageObject.ClickPossessionButton();
        }

        [When(@"I click Basement")]
        public void WhenIClickBasement()
        {
            _homePageObject.NavigateToBasement();
        }

        [When(@"I scroll down")]
        public void WhenIScrollDown()
        {
            _basementPageObject.ScrollDown();
        }

        [When(@"I click on the piano")]
        public void WhenIClickOnThePiano()
        {
            _basementPageObject.ClickPiano();
        }

        [Then(@"the piano alert appears")]
        public void ThenThePianoAlertAppears()
        {
            _basementPageObject.VerifyPianoAlertAppears();
        }
    }
}
