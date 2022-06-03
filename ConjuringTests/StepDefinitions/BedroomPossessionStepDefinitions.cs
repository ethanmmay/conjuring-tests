using ConjuringTests.Pages;
using ConjuringTests.Drivers;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class BedroomPossessionStepDefinitions
    {
        // Instantiating Necessary PageObjects for test methods
        private readonly HomePageObject _homePage;
        private readonly BedroomBPageObject _bedroomBPage;

        // Retrieving PageObject methods using current Driver
        public BedroomPossessionStepDefinitions(BrowserDriver browserDriver)
        {
            _homePage = new HomePageObject(browserDriver.Current);
            _bedroomBPage = new BedroomBPageObject(browserDriver.Current);
        }

        // Verifying driver's location at test site
        [Given(@"I am on conjuring site going towards BedroomB")]
        public void GivenIAmOnConjuringSite3()
        {
            _homePage.VerifyAtHomePage();
        }

        // Clicking "Possession" button to alter links
        [When(@"I click possession for going to BedroomB")]
        public void WhenIClickPossesion3()
        {
            _homePage.ClickPossessionButton();
        }

        // Navigating to BedroomB Page
        [When(@"I click BedroomB")]
        public void WhenIClickBedroomB()
        {
            _homePage.NavigateToBedroomB();
        }

        // Moving range input to maximum and back 3 times
        [When(@"I raise and lower slider 3 times")]
        public void WhenIRaiseAndLowerSlider3Times()
        {
            _bedroomBPage.RaiseAndLowerSlider();
            _bedroomBPage.RaiseAndLowerSlider();
            _bedroomBPage.RaiseAndLowerSlider();
        }

        // Verifying the range input's value is 0
        [Then(@"the slider is back at 0")]
        public void ThenTheSliderIsBackAt0()
        {
            String sliderValue = _bedroomBPage.GetSliderValue();
            sliderValue.Should().Be("0");
        }


    }
}
