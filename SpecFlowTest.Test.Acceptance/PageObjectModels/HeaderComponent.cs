using OpenQA.Selenium;

namespace SpecFlowTest.Test.Acceptance.PageObjectModels;

public class HeaderComponent
{
    private readonly IWebDriver _driver;

    public HeaderComponent(IWebDriver driver)
    {
        _driver = driver;
    }

    public PageObjectModels.LoginPage LoginPageLinkClick()
    {
        _driver.FindElement(By.XPath("/html/body/header/nav/div/div/ul[2]/li[2]/a")).Click();
        return new PageObjectModels.LoginPage(_driver);
    }
}