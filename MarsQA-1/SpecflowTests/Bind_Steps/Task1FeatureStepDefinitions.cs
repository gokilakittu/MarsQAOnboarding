using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class Task1FeatureStepDefinitions : Driver
    {
        LoginPage LoginPageObj = new LoginPage();
        ProfilePage ProfilePageObj = new ProfilePage();
        SignIn SignInObj = new SignIn();

        [Given(@"I logged into the mars portal successfully")]
        public void GivenILoggedIntoTheMarsPortalSuccessfully()
        {
            SignInObj.LoginSteps();
            if (LoginPageObj.ConfirmUser() == false)
            {
                Assert.Fail("The was a session error");
            }
        }

        [When(@"I click on the edit button near the description")]
        public void WhenIClickOnTheEditButtonNearTheDescription()
        {
            ProfilePageObj.ClickEditDescription();
        }

        [When(@"I enter the '([^']*)'")]
        public void WhenIEnterThe(string description)
        {
            ProfilePageObj.EnterDescription(description);
        }

        [Then(@"I could see the newly added '([^']*)' successfully")]
        public void ThenICouldSeeTheNewlyAddedSuccessfully(string description)
        {
            if (ProfilePageObj.ValidateDescription(description) == false)
            {
                Assert.Fail("The actual description is different from the expected description");
            }
        }

        // Negative Scenario
        [Then(@"I could see the partial text of the description with showing any error message")]
        public void ThenICouldSeeThePartialTextOfTheDescriptionWithShowingAnyErrorMessage()
        {
            throw new PendingStepException();
        }

        // Negative Scenario
        [When(@"I clear the data in the description")]
        public void WhenIClearTheDataInTheDescription()
        {
            throw new PendingStepException();
        }

        // Negative Scenario
        [Then(@"an error message should appear for blank description")]
        public void ThenAnErrorMessageShouldAppearForBlankDescription()
        {
            throw new PendingStepException();
        }

        [When(@"I click on the profile name")]
        public void WhenIClickOnTheProfileName()
        {
            ProfilePageObj.ClickEditName();
        }

        [When(@"I edit my '([^']*)' and '([^']*)'")]
        public void WhenIEditMyAnd(string firstname, string lastname)
        {
            ProfilePageObj.EnterNames(firstname, lastname);
        }

        [Then(@"I could see the updated '([^']*)' and '([^']*)' successfully")]
        public void ThenICouldSeeTheUpdatedAndSuccessfully(string firstname, string lastname)
        {
            if (ProfilePageObj.ValidateName(firstname, lastname) == false)
            {
                Assert.Fail("The names doesnot match");
            }
        }

        [When(@"I clear all the data")]
        public void WhenIClearAllTheData()
        {
            throw new PendingStepException();
        }

        [Then(@"an error message should appear for blank names")]
        public void ThenAnErrorMessageShouldAppearForBlankNames()
        {
            throw new PendingStepException();
        }

        [When(@"I enter only the firstname '([^']*)'")]
        public void WhenIEnterOnlyTheFirstname(string firstname)
        {
            throw new PendingStepException();
        }

        [When(@"I enter only the lastname '([^']*)'")]
        public void WhenIEnterOnlyTheLastname(string lastname)
        {
            throw new PendingStepException();
        }

        [When(@"I click on the edit button near the availability")]
        public void WhenIClickOnTheEditButtonNearTheAvailability()
        {
            ProfilePageObj.ClickEditAvailability();
        }

        [When(@"I select the availability '([^']*)'")]
        public void WhenISelectTheAvailability(string availability)
        {
            ProfilePageObj.SelectAvailability(availability);
        }

        [Then(@"I could see the newly added '([^']*)' availability successfully")]
        public void ThenICouldSeeTheNewlyAddedAvailabilitySuccessfully(string availability)
        {
            if (ProfilePageObj.ValidateAvailability(availability) == false)
            {
                Assert.Fail("The availability doesnot match");
            }
        }

        [When(@"I click on the edit button near the hours")]
        public void WhenIClickOnTheEditButtonNearTheHours()
        {
            ProfilePageObj.ClickEditHours();
        }

        [When(@"I select the hours '([^']*)'")]
        public void WhenISelectTheHours(string hours)
        {
            ProfilePageObj.SelectHours(hours);
        }

        [Then(@"I could see the newly added '([^']*)' hours successfully")]
        public void ThenICouldSeeTheNewlyAddedHoursSuccessfully(string hours)
        {
            if (ProfilePageObj.ValidateHours(hours) == false)
            {
                Assert.Fail("The hours doesnot match");
            }
        }

        [When(@"I click on the edit button near the earn target")]
        public void WhenIClickOnTheEditButtonNearTheEarnTarget()
        {
            ProfilePageObj.ClickEditEarnTarget();
        }

        [When(@"I select the  earntarget '([^']*)'")]
        public void WhenISelectTheEarntarget(string earnTarget)
        {
            ProfilePageObj.SelectEarnTarget(earnTarget);
        }

        [Then(@"I could see the newly added '([^']*)' earn target successfully")]
        public void ThenICouldSeeTheNewlyAddedEarnTargetSuccessfully(string earnTarget)
        {
        
            if (ProfilePageObj.ValidateEarnTarget(earnTarget) == false)
            {
                Assert.Fail("The Earn Target doesnot match");
            }
        }

        [When(@"I click add new button in language tab")]
        public void WhenIClickAddNewButtonInLanguageTab()
        {
            if (ProfilePageObj.ClickAddNewLanguage() == true)
            {
                ProfilePageObj.AddNewLanguageButton();
            }
            else
            {
                Assert.Fail("List has already four language. Please delete a language to add another.");
            }
        }

        [When(@"I enter the '([^']*)' '([^']*)' to add language")]
        public void WhenIEnterTheToAddLanguage(string language, string level)
        {
            /*To check if the add button is displayed for adding the language*/
            if (ProfilePageObj.ClickAddNewLanguage() == true)
            {
                ProfilePageObj.EnterNewLanguage(language, level);
            }
            else
            {
                Assert.Fail("List has already four language. Please delete a language to add another.");
            }
        }

        [Then(@"The new language '([^']*)''([^']*)' was successfully created")]
        public void ThenTheNewLanguageWasSuccessfullyCreated(string validateLanguage, string validateLevel)
        {
            var newLangaugeStatus = ProfilePageObj.ValidateNewLanguage(validateLanguage, validateLevel);

            if (newLangaugeStatus.Item1 == "N")
            {
                Assert.Fail(newLangaugeStatus.Item2);
            }
        }

       [When(@"I click add button to add language")]
        public void WhenIClickAddButtonToAddLanguage()
        {
            throw new PendingStepException();
        }

        [Then(@"an error message should appear for empty values")]
        public void ThenAnErrorMessageShouldAppearForEmptyValues()
        {
            throw new PendingStepException();
        }

        [When(@"I select '([^']*)' in the language level")]
        public void WhenISelectInTheLanguageLevel(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"I select '([^']*)' in the language")]
        public void WhenISelectInTheLanguage(string french)
        {
            throw new PendingStepException();
        }

        [When(@"I select '([^']*)' '([^']*)'")]
        public void WhenISelect(string tamil, string p1)
        {
            throw new PendingStepException();
        }

        [Then(@"an error message should appear for data already exists")]
        public void ThenAnErrorMessageShouldAppearForDataAlreadyExists()
        {
            throw new PendingStepException();
        }

        [When(@"I select '([^']*)' '([^']*)' to add the language")]
        public void WhenISelectToAddTheLanguage(string tamil, string fluent)
        {
            throw new PendingStepException();
        }

        [Then(@"an error message should appear for duplicate values")]
        public void ThenAnErrorMessageShouldAppearForDuplicateValues()
        {
            throw new PendingStepException();
        }

        [When(@"I edit '([^']*)' with '([^']*)' '([^']*)' to update language")]
        public void WhenIEditWithToUpdateLanguage(string languageToBeEdited, string editLanguage, string editLanguageLevel)
        {
            ProfilePageObj.EnterEditLanguage(languageToBeEdited,editLanguage, editLanguageLevel);
        }

        [Then(@"The language was successfully updated with '([^']*)''([^']*)'")]
        public void ThenTheLanguageWasSuccessfullyUpdatedWith(string updatedLanguage, string updatedLanguageLevel)
        {
            var editLangaugeStatus = ProfilePageObj.ValidateUpdatedLanguage(updatedLanguage, updatedLanguageLevel);
            if (editLangaugeStatus.Item1 == "N")
            {
                Assert.Fail(editLangaugeStatus.Item2);
            }
        }

        [When(@"I click delete button of the '([^']*)' language i want to delete")]
        public void WhenIClickDeleteButtonOfTheLanguageIWantToDelete(string deleteLanguage)
        {
            String deleteStatus = ProfilePageObj.DeleteLanguage(deleteLanguage);
            if (deleteStatus == "N")
            {
                Assert.Fail(deleteStatus);
            }
        }

        [Then(@"The '([^']*)' language was deleted successfully")]
        public void ThenTheLanguageWasDeletedSuccessfully(string deleteLanguage)
        {
            var deletionStatus = ProfilePageObj.ValidateDeletion(deleteLanguage);
            if (deletionStatus.Item1 == "N")
            {
                Assert.Fail(deletionStatus.Item2);
            }
        }

        [When(@"I am in the skill tab")]
        public void WhenIAmInTheSkillTab()
        {
            ProfilePageObj.GoToSkillTab();
        }

        [When(@"I enter the '([^']*)' '([^']*)' to add the skill")]
        public void WhenIEnterTheToAddTheSkill(string skill, string skillLevel)
        {
            ProfilePageObj.EnterNewSkill(skill, skillLevel);
        }

        [Then(@"The new '([^']*)''([^']*)' was successfully created")]
        public void ThenTheNewWasSuccessfullyCreated(string validateSkill, string validateSkillLevel)
        {
            var NewAddSkillStatus = ProfilePageObj.ValidateNewSkill(validateSkill, validateSkillLevel);
            if (NewAddSkillStatus.Item1 == "N")
            {
                Assert.Fail(NewAddSkillStatus.Item2);
            }

        }

        [When(@"I click add button to add skill")]
        public void WhenIClickAddButtonToAddSkill()
        {
            throw new PendingStepException();
        }

        [When(@"I select '([^']*)' in the skill level")]
        public void WhenISelectInTheSkillLevel(string beginner)
        {
            throw new PendingStepException();
        }

        [When(@"I select '([^']*)' in the skill")]
        public void WhenISelectInTheSkill(string postman)
        {
            throw new PendingStepException();
        }

        [Then(@"an error message should appear for data already exist")]
        public void ThenAnErrorMessageShouldAppearForDataAlreadyExist()
        {
            throw new PendingStepException();
        }

        [When(@"I select '([^']*)' '([^']*)' to add the skill")]
        public void WhenISelectToAddTheSkill(string p0, string intermediate)
        {
            throw new PendingStepException();
        }

        [When(@"I update '([^']*)' with '([^']*)' '([^']*)' to update skill")]
        public void WhenIUpdateWithToUpdateSkill(string skillToBeEdited, string editSkill, string editSkillLevel)
        {
            ProfilePageObj.EnterEditSkill(skillToBeEdited,editSkill, editSkillLevel);
        }

        [Then(@"The skill was successfully updated with '([^']*)''([^']*)'")]
        public void ThenTheSkillWasSuccessfullyUpdatedWith(string editSkill, string editSkillLevel)
        {
            var editSkillStatus = ProfilePageObj.ValidateUpdatedSkill(editSkill, editSkillLevel);
            Console.WriteLine(editSkillStatus);
            if (editSkillStatus.Item1 == "N")
            {
                Assert.Fail(editSkillStatus.Item2);
            }
        }

        [When(@"I click delete button of the skill '([^']*)' i want to delete")]
        public void WhenIClickDeleteButtonOfTheSkillIWantToDelete(string skillToBeDeleted)
        {
            String deleteStatus = ProfilePageObj.DeleteSkill(skillToBeDeleted);
            if (deleteStatus == "N")
            {
                Assert.Fail(deleteStatus);
            }
        }
        [Then(@"the '([^']*)' skill was deleted successfully")]
        public void ThenTheSkillWasDeletedSuccessfully(string skillToBeDeleted)
        {
            var deletionStatus = ProfilePageObj.ValidateSkillDeletion(skillToBeDeleted);
            if (deletionStatus.Item1 == "N")
            {
                Assert.Fail(deletionStatus.Item2);
            }
        }

        [When(@"I am in the education tab")]
        public void WhenIAmInTheEducationTab()
        {
            throw new PendingStepException();
        }

        [When(@"I enter the '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenIEnterThe(string nZ, string p1, string mSc, string mSc3, string p4)
        {
            throw new PendingStepException();
        }

        [Then(@"The new Education was added successfully")]
        public void ThenTheNewEducationWasAddedSuccessfully()
        {
            throw new PendingStepException();
        }
        [When(@"I update '([^']*)' with '([^']*)' '([^']*)' '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenIUpdateWith(string p0, string p1, string p2, string bSc, string bSc4, string p5)
        {
            throw new PendingStepException();
        }

        [Then(@"The education was successfully updated")]
        public void ThenTheEducationWasSuccessfullyUpdated()
        {
            throw new PendingStepException();
        }

        [When(@"I click delete button of the degree '([^']*)' i want to delete")]
        public void WhenIClickDeleteButtonOfTheDegreeIWantToDelete(string bSc)
        {
            throw new PendingStepException();
        }

        [Then(@"The  education was deleted successfully")]
        public void ThenTheEducationWasDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I am in the certificate tab")]
        public void WhenIAmInTheCertificateTab()
        {
            throw new PendingStepException();
        }

        [When(@"I enter the '([^']*)' '([^']*)' '([^']*)' to add certificate")]
        public void WhenIEnterTheToAddCertificate(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"The new certificate was added successfully")]
        public void ThenTheNewCertificateWasAddedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I update '([^']*)' with '([^']*)' '([^']*)' '([^']*)'")]
        public void WhenIUpdateWith(string p0, string p1, string p2, string p3)
        {
            throw new PendingStepException();
        }

        [Then(@"The certificate was successfully updated")]
        public void ThenTheCertificateWasSuccessfullyUpdated()
        {
            throw new PendingStepException();
        }

        [When(@"I click delete button of the '([^']*)' i want to delete")]
        public void WhenIClickDeleteButtonOfTheIWantToDelete(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"The certificate was deleted successfully")]
        public void ThenTheCertificateWasDeletedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
