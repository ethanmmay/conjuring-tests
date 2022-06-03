using ConjuringTests.Pages;
using ConjuringTests.Drivers;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class BasementPossessionStepDefinitions
    {
        // Instantiating Necessary PageObjects for test methods
        private readonly HomePageObject _homePage;
        private readonly BasementPageObject _basementPage;

        // Retrieving PageObject methods using current Driver
        public BasementPossessionStepDefinitions(BrowserDriver browserDriver)
        {
            _homePage = new HomePageObject(browserDriver.Current);
            _basementPage = new BasementPageObject(browserDriver.Current);
        }

        // Verifying driver's location at test site
        [Given(@"I am on conjuring site going towards Basement")]
        public void GivenIAmOnConjuringSite()
        {
            _homePage.VerifyAtHomePage();
        }

        // Clicking "Possession" button to alter links
        [When(@"I click possession for going to Basement")]
        public void WhenIClickPossesion()
        {
            _homePage.ClickPossessionButton();
        }

        // Navigating to BasementB Page
        [When(@"I click Basement")]
        public void WhenIClickBasement()
        {
            _homePage.NavigateToBasement();
        }

        // Navigating down the webpage to an image
        [When(@"I scroll down")]
        public void WhenIScrollDown()
        {
            _basementPage.ScrollDown();
        }

        // Clicking on image to activate alert
        [When(@"I click on the piano")]
        public void WhenIClickOnThePiano()
        {
            _basementPage.ClickPiano();
        }

        // Confirming alert
        [Then(@"the piano alert appears")]
        public void ThenThePianoAlertAppears()
        {
            _basementPage.VerifyPianoAlertAppears();
        }
    }
}
