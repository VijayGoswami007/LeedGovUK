using LeedGovUK.PageObjects;
using System;
using TechTalk.SpecFlow;
using FluentAssertions;
using NUnit.Framework;
using LeedGovUK.Support;

namespace LeedGovUK.StepDefinitions
{
    [Binding]
    public class OnlineFormTemplatesStepDefinitions
    {
        private OnlineFormTemplatesPage onlineFormTemplatesPage;

        public OnlineFormTemplatesStepDefinitions(OnlineFormTemplatesPage onlineFormTemplatesPage)
        {
            this.onlineFormTemplatesPage = onlineFormTemplatesPage;
        }

        [Given(@"I am a user of an online form")]
        public void GivenIAmAUserOfAnOnlineForm()
        {
            
        }

        [When(@"I navigate to the URL '([^']*)'")]
        public void WhenINavigateToTheURL(string url)
        {
            this.onlineFormTemplatesPage.navigateTo(url);
        }

        [Then(@"I can see the starting page of the form")]
        public void ThenICanSeeTheStartingPageOfTheForm()
        {
            var title = this.onlineFormTemplatesPage.GetPageTitle();

            //assert
            title.Should().Be("Form Template - leeds.gov.uk");
        }

        [Given(@"I have navigated to the online form")]
        public void GivenIHaveNavigatedToTheOnlineForm()
        {
            this.onlineFormTemplatesPage.navigateTo(Constants.TheOnlineFormUrl);
        }

        [Given(@"I am on the starting page")]
        public void GivenIAmOnTheStartingPage()
        {
            var title = this.onlineFormTemplatesPage.GetPageTitle();

            //assert
            Assert.AreEqual("Form Template - leeds.gov.uk", title);
            title.Should().Be("Form Template - leeds.gov.uk");
        }

        [When(@"I click ‘Start now’")]
        public void WhenIClickStartNow()
        {
            this.onlineFormTemplatesPage.StartNow();
        }

        [Then(@"I can see first question page of the form")]
        public void ThenICanSeeFirstQuestionPageOfTheForm()
        {
            var firstQuestion = this.onlineFormTemplatesPage.GetFirstQuestion();
            firstQuestion.Should().Be("Are you able to pin an exact location on a map where the issue is?");
        }

        [Given(@"I am on the first question page of the form")]
        public void GivenIAmOnTheFirstQuestionPageOfTheForm()
        {
           
        }

        [When(@"I select nothing")]
        public void WhenISelectNothing()
        {
            //Nothing here todo.
        }

        [When(@"click ‘Continue’")]
        public void WhenClickContinue()
        {
            this.onlineFormTemplatesPage.clickOnContinue();
        }

        [Then(@"I can see an error message")]
        public void ThenICanSeeAnErrorMessage()
        {
            var errorMessage = this.onlineFormTemplatesPage.getErrorMessage();
            errorMessage.Should().Be("Select an option");
        }


        [Given(@"I am on the first question page")]
        public void GivenIAmOnTheFirstQuestionPage()
        {
            
        }

        [When(@"I select ‘No’")]
        public void WhenISelectNo()
        {
            this.onlineFormTemplatesPage.getSelectNoRadioButton();
        }

        [When(@"click the ‘Continue’ button")]
        public void WhenClickTheContinueButton()
        {
            this.onlineFormTemplatesPage.clickOnContinue();
        }

        [Then(@"I can see the ‘Map’ page")]
        public void ThenICanSeeTheMapPage()
        {
            this.onlineFormTemplatesPage.getMapPageHeading();
        }


        [Given(@"I am on the Map page")]
        public void GivenIAmOnTheMapPage()
        {
            this.onlineFormTemplatesPage.getMapPageHeading();
        }

        [When(@"I enter the postcode '([^']*)' in the box")]
        public void WhenIEnterThePostcodeInTheBox(string postcode)
        {
            this.onlineFormTemplatesPage.doInputPostalCode(postcode);
        }

        [When(@"click ‘Find address’")]
        public void WhenClickFindAddress()
        {
            this.onlineFormTemplatesPage.doFindAddressButton();
        }

        [Then(@"I can select the address '([^']*)'")]
        public void ThenICanSelectTheAddress(string address)
        {
            this.onlineFormTemplatesPage.doSelectDropBox(address);
        }

        [Then(@"I can click Continue")]
        public void ThenICanClickContinue()
        {
            
        }


    }
}
