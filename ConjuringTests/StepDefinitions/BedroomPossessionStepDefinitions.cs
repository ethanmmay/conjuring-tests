using ConjuringTests.Pages;
using ConjuringTests.Drivers;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class BedroomPossessionStepDefinitions
    {
        private readonly HomePageObject _homePageObject;
        private readonly BedroomBPageObject _bedroomBPageObject;

        public BedroomPossessionStepDefinitions(BrowserDriver browserDriver)
        {
            _homePageObject = new HomePageObject(browserDriver.Current);
            _bedroomBPageObject = new BedroomBPageObject(browserDriver.Current);
        }

        [Given(@"I am on conjuring site going towards BedroomB")]
        public void GivenIAmOnConjuringSite3()
        {
            _homePageObject.VerifyAtHomePage();
        }

        [When(@"I click possession for going to BedroomB")]
        public void WhenIClickPossesion3()
        {
            _homePageObject.ClickPossessionButton();
        }

        [When(@"I click BedroomB")]
        public void WhenIClickBedroomB()
        {
            _homePageObject.NavigateToBedroomB();
        }

        [When(@"I raise and lower slider 3 times")]
        public void WhenIRaiseAndLowerSlider3Times()
        {
            _bedroomBPageObject.RaiseAndLowerSlider();
            _bedroomBPageObject.RaiseAndLowerSlider();
            _bedroomBPageObject.RaiseAndLowerSlider();
        }

        [Then(@"the slider is back at 0")]
        public void ThenTheSliderIsBackAt0()
        {
            String sliderValue = _bedroomBPageObject.GetSliderValue();
            sliderValue.Should().Be("0");
        }


    }
}
