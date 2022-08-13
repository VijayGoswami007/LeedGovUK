using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using LeedGovUK.Support;

namespace LeedGovUK.StepDefinitions
{
    [Binding]
    public class Hooks
    {

        public static WebDriver? Driver;

        [BeforeFeature]
        public static void SetUp()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            /*chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.AddArgument("--disable-infobars");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--window-size=1200,900");
            chromeOptions.AddArgument("--disable-browser-side-navigation");*/

            ChromeDriver driver = new ChromeDriver(Constants.ChromePath, chromeOptions);

            Hooks.Driver = driver;
        }

        [AfterFeature]
        public static void TearDown()
        {
            if (Hooks.Driver != null)
            {
                Hooks.Driver.Quit();
                Hooks.Driver = null;
            }
        }
    }
}