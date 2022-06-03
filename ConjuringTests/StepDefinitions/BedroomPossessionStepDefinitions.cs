using ConjuringTests.Pages;
using ConjuringTests.Drivers;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class BedroomPossessionStepDefinitions
    {
        private readonly HomePageObject _homePage;
        private readonly BedroomBPageObject _bedroomBPage;

        public BedroomPossessionStepDefinitions(BrowserDriver browserDriver)
        {
            _homePage = new HomePageObject(browserDriver.Current);
            _bedroomBPage = new BedroomBPageObject(browserDriver.Current);
        }

        [Given(@"I am on conjuring site going towards BedroomB")]
        public void GivenIAmOnConjuringSite3()
        {
            _homePage.VerifyAtHomePage();
        }

        [When(@"I click possession for going to BedroomB")]
        public void WhenIClickPossesion3()
        {
            _homePage.ClickPossessionButton();
        }

        [When(@"I click BedroomB")]
        public void WhenIClickBedroomB()
        {
            _homePage.NavigateToBedroomB();
        }

        [When(@"I raise and lower slider 3 times")]
        public void WhenIRaiseAndLowerSlider3Times()
        {
            _bedroomBPage.RaiseAndLowerSlider();
            _bedroomBPage.RaiseAndLowerSlider();
            _bedroomBPage.RaiseAndLowerSlider();
        }

        [Then(@"the slider is back at 0")]
        public void ThenTheSliderIsBackAt0()
        {
            String sliderValue = _bedroomBPage.GetSliderValue();
            sliderValue.Should().Be("0");
        }


    }
}
