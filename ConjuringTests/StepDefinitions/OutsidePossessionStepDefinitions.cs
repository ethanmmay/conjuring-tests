using ConjuringTests.Pages;
using ConjuringTests.Drivers;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class OutsidePossessionStepDefinitions
    {
        private readonly HomePageObject _homePageObject;
        private readonly OutsidePageObject _outsidePageObject;

        public OutsidePossessionStepDefinitions(BrowserDriver browserDriver)
        {
            _homePageObject = new HomePageObject(browserDriver.Current);
            _outsidePageObject = new OutsidePageObject(browserDriver.Current);
        }

        [Given(@"I am on conjuring site going towards Outside")]
        public void GivenIAmOnConjuringSite2()
        {
            _homePageObject.VerifyAtHomePage();
        }

        [When(@"I click possession for going Outside")]
        public void WhenIClickPossesion2()
        {
            _homePageObject.ClickPossessionButton();
        }

        [When(@"I click Outside")]
        public void WhenIClickOutside()
        {
            _homePageObject.NavigateToOutside();
        }

        [When(@"I click 20 crows")]
        public void WhenIClick20Crows()
        {
            _outsidePageObject.Click20Crows();
        }

        [Then(@"the crows possessed is 20")]
        public void ThenTheCrowsPossessedIs20()
        {
            _outsidePageObject.Verify20CrowsClicked();
        }
    }
}
