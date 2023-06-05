using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    [Binding]
    public class GeneralDetailsFeatureStepDefinitions:Driver
    {
        LoginPage LoginPageObj = new LoginPage();
        ProfilePage ProfilePageObj = new ProfilePage();

        [When(@"I am in the profile page")]
        public void WhenIAmInTheProfilePage()
        {
            
        }

        [When(@"I Click the edit button near the decription")]
        public void WhenIClickTheEditButtonNearTheDecription()
        {
            ProfilePageObj.ClickEditDescription(); 
            
        }

        [When(@"I enter the '([^']*)' in decription")]
        public void WhenIEnterTheInDecription(string description)
        {
            ProfilePageObj.EnterDescription(description);
        }

        [When(@"I click on the save button")]
        public void WhenIClickOnTheSaveButton()
        {
            ProfilePageObj.ClickSaveDescription();
            
        }

        [Then(@"i could see '([^']*)' of the profile successfully")]
        public void ThenICouldSeeTheDecriptionOfTheProfileSuccessfully(String description)
        {
            
            if (ProfilePageObj.ValidateDescription(description) == false)
            {
                Assert.Fail("The actual description is different from the expected description");
            }
        }

        [When(@"I Click on my fullname")]
        public void WhenIClickOnMyFullname()
        {
            ProfilePageObj.ClickEditName();
        }

        [When(@"I enter the '([^']*)' '([^']*)'")]
        public void WhenIEnterThe(string firstname, string lastname)
        {
            ProfilePageObj.EnterNames(firstname, lastname);
        }


        [Then(@"I could see the '([^']*)' '([^']*)' saved to the profile successfully")]
        public void ThenICouldSeeTheSavedToTheProfileSuccessfully(string firstname, string lastname)
        {
            if (ProfilePageObj.ValidateName(firstname, lastname) == false)
            {
                Assert.Fail("The names doesnot match");
            }
        }
        [When(@"I click on the save button to save the names")]
        public void WhenIClickOnTheSaveButtonToSaveTheNames()
        {
            ProfilePageObj.ClickSaveName();
        }


        [When(@"I click the edit button near the availability")]
        public void WhenIClickTheEditButtonNearTheAvailability()
        {
            ProfilePageObj.ClickEditAvailability();
        }
        
        [When(@"I select the availability to '([^']*)'")]
        public void AndISelectTheAvailabilityTo(string availability)
        {
            ProfilePageObj.SelectAvailability(availability);
        }

        [Then(@"i could see the '([^']*)' availability successfully")]
        public void ThenICouldSeeTheAvailabilitySuccessfully(String availability)
        {
            if (ProfilePageObj.ValidateAvailability(availability) == false)
            {
                Assert.Fail("The availability doesnot match");
            }
        }


        [When(@"I Click the edit button near the hours")]
        public void WhenIClickTheEditButtonNearTheHours()
        {
            ProfilePageObj.ClickEditHours();
        }

        [When(@"I select the hours to '([^']*)'")]
        public void WhenISelectTheHoursTo(string hours)
        {
            ProfilePageObj.SelectHours(hours);
        }

        [Then(@"i could see the '([^']*)' hours successfully")]
        public void ThenICouldSeeTheHoursSuccessfully(String hours)
        {
            if (ProfilePageObj.ValidateHours(hours) == false)
            {
                Assert.Fail("The hours doesnot match");
            }
        }

        [When(@"I Click the edit button near the earn target")]
        public void WhenIClickTheEditButtonNearTheEarnTarget()
        {
            ProfilePageObj.ClickEditEarnTarget();
        }

        [When(@"I select the earn target  to '([^']*)'")]
        public void WhenISelectTheEarnTargetTo(string earnTarget)
        {
            ProfilePageObj.SelectEarnTarget(earnTarget);
        }

        [Then(@"i could see the '([^']*)' earn target successfully")]
        public void ThenICouldSeeTheEarnTargetSuccessfully(String earnTarget)
        {
            if (ProfilePageObj.ValidateEarnTarget(earnTarget) == false)
            {
                Assert.Fail("The Earn Target doesnot match");
            }
        }

    }
}
