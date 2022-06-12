using OpenQA.Selenium;

namespace SpecFlowTest.Test.Acceptance.StepDefinitions;

[Binding]
public class MainNavigation
{
    private readonly IWebDriver _driver;

    private readonly By _logInLink = By.XPath("/html/body/header/nav/div/div/ul[2]/li[2]/a");
    private readonly By _homePageLink = By.XPath("/html/body/header/nav/div/div/ul[1]/li[1]/a");

    public MainNavigation(IWebDriver driver)
    {
        _driver = driver;
    }

    [When(@"the user clicks on the log in link")]
    public void WhenTheUserClicksOnTheLogInLink()
    {
        _driver.FindElement(_logInLink).Click();
    }

    [Then(@"the log in page loads")]
    public void ThenTheLogInPageLoads()
    {
        _driver.Title.Should().Be("Log in");
    }

    [When(@"the user clicks on the Home link")]
    public void WhenTheUserClicksOnTheHomeLink()
    {
        _driver.FindElement(_homePageLink).Click();
    }

    [Then(@"the Home page loads")]
    public void ThenTheHomePageLoads()
    {
        _driver.Title.Should().Be("Home page");
    }
}