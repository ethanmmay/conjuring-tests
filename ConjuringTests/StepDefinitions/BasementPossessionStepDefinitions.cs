using ConjuringTests.Pages;
using ConjuringTests.Drivers;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class BasementPossessionStepDefinitions
    {
        private readonly HomePageObject _homePageObject;

        public BasementPossessionStepDefinitions(BrowserDriver browserDriver)
        {
            _homePageObject = new HomePageObject(browserDriver.Current);
        }

        //private readonly BasementPossession _basementPossession = new BasementPossession();
        [Given(@"I am on conjuring site")]
        public void GivenIAmOnConjuringSite()
        {
            _homePageObject.VerifyAtHomePage();
        }

        [When(@"I click possession")]
        public void WhenIClickPossesion()
        {
            _homePageObject.ClickPossessionButton();
        }

        [When(@"I click Basement")]
        public void WhenIClickBasement()
        {
            _homePageObject.NavigateToBasement();
        }

        [Then(@"the result page should have link `https://ethanmmay.github.io/conjuring-site/basement-b`")]
        public void ResultsPageHasBasementLink()
        {
            _homePageObject.VerifyAtBasement();
        }
    }
}
