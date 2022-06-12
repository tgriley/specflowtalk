using OpenQA.Selenium;

namespace SpecFlowTest.Test.Acceptance.PageObjectModels;

public class Homepage
{
    private readonly IWebDriver _driver;

    public const string Url = "https://localhost:7005/";

    public string Title => _driver.Title;
    public string H1 => _driver.FindElement(By.TagName("H1")).Text;

    public Homepage(IWebDriver driver)
    {
        _driver = driver;
        if (_driver.Title != "Home page")
        {
            throw new Exception($"This is not the homepage... this is {_driver.Title} at {_driver.Url}");
        }
    }
}