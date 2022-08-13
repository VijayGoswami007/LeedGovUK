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

        [Given(@"I am a user of an online form")]
        public void GivenIAmAUserOfAnOnlineForm()
        {
            this.onlineFormTemplatesPage = new OnlineFormTemplatesPage(Hooks.Driver);
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
            this.onlineFormTemplatesPage = new OnlineFormTemplatesPage(Hooks.Driver);
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
    }
}
