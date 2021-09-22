using NUnit.Framework;
using SeleniumPOMWalkthrough.utils;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumPOMWalkthrough.BDD
{
    [Binding]
    [Scope(Tag ="Base")]
    public class DerivedSteps : Base
    {
        private Credentials _credentials;
        [Given(@"I want to sign in")]
        public override void GivenIWantToSignIn()
        {
            base.GivenIWantToSignIn();
        }
        
        [Given(@"the following details")]
        public override void GivenTheFollowingDetails(Table table)
        {
            base.GivenTheFollowingDetails(table);
        }
        
        [When(@"I press sign in")]
        public override void WhenIPressSignIn()
        {
            base.WhenIPressSignIn();
        }
        
        [Then(@"I can see the next page")]
        public override void ThenICanSeeTheNextPage()
        {
            base.ThenICanSeeTheNextPage();
        }
        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
