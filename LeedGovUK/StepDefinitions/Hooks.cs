using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using LeedGovUK.Support;
using BoDi;

namespace LeedGovUK.StepDefinitions
{
    [Binding]
    public class WebDriverSupport
    {
        [BeforeFeature]
        public static void SetUp(IObjectContainer objectContainer)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            /*
             chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.AddArgument("--disable-infobars");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--window-size=1200,900");
            chromeOptions.AddArgument("--disable-browser-side-navigation");
            */

            ChromeDriver webDriver = new ChromeDriver(Constants.ChromePath, chromeOptions);
            objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }

        [AfterFeature]
        public static void TearDown(IObjectContainer objectContainer)
        {
            var driver = objectContainer.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}