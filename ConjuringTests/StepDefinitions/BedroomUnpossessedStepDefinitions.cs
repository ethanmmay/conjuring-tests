using ConjuringTests.Pages;
using ConjuringTests.Drivers;
namespace ConjuringTests.StepDefinitions
{
    [Binding]
    public class BedroomUnpossessedStepDefinitions
    {
        private readonly HomePageObject _homePageObject;
        private readonly BedroomGPageObject _bedroomGPageObject;

        public BedroomUnpossessedStepDefinitions(BrowserDriver browserDriver)
        {
            _homePageObject = new HomePageObject(browserDriver.Current);
            _bedroomGPageObject = new BedroomGPageObject(browserDriver.Current);
        }

        [Given(@"I am on conjuring site going towards BedroomG")]
        public void GivenIAmOnConjuringSite3()
        {
            _homePageObject.VerifyAtHomePage();
        }

        [When(@"I click BedroomG")]
        public void WhenIClickBedroomG()
        {
            _homePageObject.NavigateToBedroomG();
        }

        [When(@"I click on wardrobe and alert")]
        public void WhenIClickOnWardrobeAndAlert()
        {
            _bedroomGPageObject.ClickWardrobeAndAlert();
        }

        [When(@"I enter low weight and submit")]
        public void WhenIEnterLowWeightAndSubmit()
        {
            _bedroomGPageObject.EnterWeightAndSubmit(80);
        }

        [When(@"I repeat steps and enter high weight")]
        public void WhenIRepeatStepsAndEnterHighWeight()
        {
            _bedroomGPageObject.RepeatStepsAndEnterHighWeight(120);
        }

        [Then(@"I fall through the house")]
        public void ThenIFallThroughTheHouse()
        {
            //_bedroomGPageObject.VerifyFallThroughHouse();
        }
    }
}
