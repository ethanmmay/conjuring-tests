using ConjuringTests.Pages;
using ConjuringTests.Drivers;
using FluentAssertions;
using TechTalk.SpecFlow;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class OutsidePossessionStepDefinitions
    {
        private readonly HomePageObject _homePage;
        private readonly OutsidePageObject _outsidePage;

        public OutsidePossessionStepDefinitions(BrowserDriver browserDriver)
        {
            _homePage = new HomePageObject(browserDriver.Current);
            _outsidePage = new OutsidePageObject(browserDriver.Current);
        }

        [Given(@"I am on conjuring site going towards Outside")]
        public void GivenIAmOnConjuringSite2()
        {
            _homePage.VerifyAtHomePage();
        }

        [When(@"I click possession for going Outside")]
        public void WhenIClickPossesion2()
        {
            _homePage.ClickPossessionButton();
        }

        [When(@"I click Outside")]
        public void WhenIClickOutside()
        {
            _homePage.NavigateToPageAndConfirm("Outside", "outside-b.html").Should().BeTrue();
        }

        [When(@"I click 20 crows")]
        public void WhenIClick20Crows()
        {
            _outsidePage.Click20Crows();
        }

        [Then(@"the crows possessed is 20")]
        public void ThenTheCrowsPossessedIs20()
        {
            String crowCount = _outsidePage.GetCrowCount();
            crowCount.Should().Be("20");
        }
    }
}
