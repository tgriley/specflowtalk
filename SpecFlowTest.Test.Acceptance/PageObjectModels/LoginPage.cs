using OpenQA.Selenium;

namespace SpecFlowTest.Test.Acceptance.PageObjectModels;

public class LoginPage
{
    private readonly IWebDriver _driver;
    private readonly By _emailAddressField = By.XPath("/html/body/div/main/div/div[1]/section/form/div[1]/input");
    private readonly By _passwordField = By.XPath("/html/body/div/main/div/div[1]/section/form/div[2]/input");
    private readonly By _submitButton = By.XPath("/html/body/div/main/div/div[1]/section/form/div[4]/button");

    public const string Url = "https://localhost:7005/Identity/Account/Login";

    public string Title => _driver.Title;
    public string H1 => _driver.FindElement(By.TagName("H1")).Text;

    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
        if (_driver.Title != "Log in")
        {
            throw new Exception($"This is not the Log in page... this is {_driver.Title} at {_driver.Url}");
        }
    }

    public LoginPage EnterEmailAddress(string emailAddress)
    {
        _driver.FindElement(_emailAddressField).SendKeys(emailAddress);
        return this;
    }

    public LoginPage EnterPassword(string password)
    {
        _driver.FindElement(_passwordField).SendKeys(password);
        return this;
    }

    public LoginPage SubmitButtonClick()
    {
        _driver.FindElement(_submitButton).Click();
        return this;
    }
}