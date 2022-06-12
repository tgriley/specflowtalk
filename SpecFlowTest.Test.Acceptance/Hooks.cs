using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowTest.Test.Acceptance;

[Binding]
public sealed class Hooks
{
    private readonly IObjectContainer _objectContainer;
    private IWebDriver? _driver;

    public Hooks(IObjectContainer objectContainer)
    {
        _objectContainer = objectContainer;
    }

    [BeforeScenario]
    public void BeforeScenario()
    {
        _driver = new ChromeDriver();
        _objectContainer.RegisterInstanceAs(_driver, typeof(IWebDriver));
    }

    [AfterScenario]
    public void AfterScenario()
    {
        if (_driver != null)
        {
            _driver.Dispose();
            _driver = null;
        }
    }
}