using OpenQA.Selenium;

namespace SpecFlowTest.Test.Acceptance.StepDefinitions
{
    [Binding]
    public class HomepageStepDefinitions
    {
        private readonly IWebDriver _driver;
        
        private PageObjectModels.Homepage _homepage;
        
        public HomepageStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"the user is on the Homepage")]
        public void GivenTheUserIsOnTheHomepage()
        {
            _driver.Url = PageObjectModels.Homepage.Url;
            _homepage = new PageObjectModels.Homepage(_driver);
        }

        [Then(@"the page title should be Home page")]
        public void ThenThePageTitleShouldBe()
        {
            _homepage.Title.Should().Be("Home page");
        }

        [Then(@"the page h1 should be correct")]
        public void ThenThePageH1ShouldBe()
        {
            _homepage.H1.Should().Be("Welcome");
        }
    }
}
