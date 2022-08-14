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

        [FindsBy(How = How.Id, Using = "continue-Button")]
        [CacheLookup]
        private IWebElement continueButton;

        [FindsBy(How = How.Id, Using = "CanPlacePin-error")]
        [CacheLookup]
        private IWebElement errorMessage;

        [FindsBy(How = How.Id, Using = "radio-No")]
        [CacheLookup]
        private IWebElement selectNoRadioButton;

        [FindsBy(How = How.ClassName, Using = "heading-large")]
        [CacheLookup]
        private IWebElement mapPageHeading;

        [FindsBy(How = How.Id, Using = "Search")]
        [CacheLookup]
        private IWebElement inputPostalCode;

        [FindsBy(How = How.Id, Using = "search-button")]
        [CacheLookup]
        private IWebElement findAddressButton;

        [FindsBy(How = How.Id, Using = "addresses")]
        [CacheLookup]
        private IWebElement selectDropBox;


        [FindsBy(How = How.Id, Using = "continue-Button")]
        [CacheLookup]
        private IWebElement afterAddressAndContinueButton;

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

        public void clickOnContinue()
        {
            WaitUntilElementVisible(this.continueButton);
            this.continueButton.Click();
        }

        public string getErrorMessage()
        {
            return this.errorMessage.Text;
        }

        public void getSelectNoRadioButton()
        {
            WaitUntilElementVisible(this.selectNoRadioButton);
            this.selectNoRadioButton.Click();
        }

        public string getMapPageHeading()
        {
            return this.mapPageHeading.Text;
        }


        public void doInputPostalCode(string postcode)
        {
            inputPostalCode.SendKeys(postcode);
        }

        public void doSelectDropBox(string address)
        {
            WaitUntilElementVisible(this.selectDropBox);
            var selectAddress = new SelectElement(this.selectDropBox);
            var option = selectAddress.Options.FirstOrDefault(o => o.Text.StartsWith(address));

            if (option != null)
                option.Click();
        }

        public void doFindAddressButton()
        {
            WaitUntilElementVisible(this.findAddressButton);
            this.findAddressButton.Click();
        }

        public void doAfterAddressAndContinueButton()
        {
            WaitUntilElementVisible(this.afterAddressAndContinueButton);
            this.afterAddressAndContinueButton.Click();
        }
    }
}
