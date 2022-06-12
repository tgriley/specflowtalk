using OpenQA.Selenium;
using SpecFlowTest.Test.Acceptance.PageObjectModels;

namespace SpecFlowTest.Test.Acceptance.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly IWebDriver _driver;
        private PageObjectModels.LoginPage _loginPage;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"the user is on the Login page")]
        public void GivenTheUserIsOnTheLoginPage()
        {
            _driver.Url = PageObjectModels.LoginPage.Url;
            _loginPage = new LoginPage(_driver);
        }

        [Then(@"the page title should be Log in")]
        public void ThenThePageTitleShouldBeLogIn()
        {
            _loginPage.Title.Should().Be("Log in");
        }

        [When(@"the user enters '(.*)' in the email address field")]
        public void WhenTheUserEntersAValidEmailAddress(string emailAddress)
        {
            _loginPage.EnterEmailAddress(emailAddress);
        }

        [When(@"the user enters '(.*)' in the password field")]
        public void WhenTheUserEntersAValidPassword(string password)
        {
            _loginPage.EnterPassword(password);
        }
        
        [When(@"the user clicks on the log in button")]
        public void WhenTheUserClicksOnTheLogInButton()
        {
            _loginPage.SubmitButtonClick();
        }

        [When(@"the user logs in with valid credentials")]
        public void WhenTheUserEntersAValidDetails()
        {
            _loginPage
                .EnterEmailAddress("valid@email.address")
                .EnterPassword("Passowrd01!")
                .SubmitButtonClick();
        }
    }
}
