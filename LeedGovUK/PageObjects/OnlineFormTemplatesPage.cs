using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedGovUK.PageObjects
{
    public class OnlineFormTemplatesPage : BasePage
    {
        public OnlineFormTemplatesPage(IWebDriver driver) : base(driver, new WebDriverWait(driver, TimeSpan.FromSeconds(10)))
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//form[contains(@action, '/FormTemplate/ServiceRequest/Information')]//button[@value='Start now']")]
        [CacheLookup]
        private IWebElement startNow;

        [FindsBy(How = How.XPath, Using = "//form//fieldset//h1[@class='heading-large']")]
        [CacheLookup]
        private IWebElement firstQuestion;

        // Go to the designated page
        public void navigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        // Returns the Page Title
        public String GetPageTitle()
        {
            return _driver.Title;
        }

        public void StartNow()
        {
            WaitUntilElementVisible(this.startNow);
            this.startNow.Click();
        }

        public string GetFirstQuestion()
        {
            return this.firstQuestion.Text;
        }
    }
}
