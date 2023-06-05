using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.SpecflowTests.Bind_Steps
{
    
    [Binding]

    public class SkillFeatureStepDefinitions : Driver
    {
        LoginPage LoginPageObj = new LoginPage();
        ProfilePage ProfilePageObj = new ProfilePage();
        
        [When(@"I am in the skill tab")]
        public void WhenIAmInTheSkillTab()
        {
            ProfilePageObj.GoToSkillTab();
        }

        [When(@"I clicked add new button in skill tab")]
        public void WhenIClickedAddNewButtonInSkillTab()
        {
            ProfilePageObj.AddNewSkillButton();
        }

        [When(@"I entered the '(.*)' '(.*)' to add skill")]
        public void WhenIEnteredTheToAddSkill(string skill, string skillLevel)
        {
            ProfilePageObj.EnterNewSkill(skill, skillLevel);
        }

        [When(@"I clicked add button to add skill")]
        public void WhenIClickedAddButtonToAddSkill()
        {
            ProfilePageObj.AddSkillButton();
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
        [When(@"I click the edit button of the '([^']*)' skill i want to edit")]
        public void WhenIClickTheEditButtonOfTheSkillIWantToEdit(String skillToBeEdited)
        {
            ProfilePageObj.EditSkill(skillToBeEdited);
        }

        [When(@"I entered the '([^']*)' '([^']*)' to edit '([^']*)' skill")]
        public void WhenIEnteredTheToEditSkill(string editSkill, string editSkillLevel, string skillToBeEdited)
        {
            ProfilePageObj.EnterEditSkill(editSkill, editSkillLevel);
        }

        [When(@"I clicked update button to edit skill")]
        public void WhenIClickedUpdateButtonToEditSkill()
        {
            ProfilePageObj.UpdateSkillButton();
        }

        [Then(@"The skill was successfully updated with '([^']*)''([^']*)'")]
        public void ThenTheSkillWasSuccessfullyUpdatedWith(string editSkill, string editSkillLevel)
        {
            var editSkillStatus = ProfilePageObj.ValidateUpdatedSkill(editSkill, editSkillLevel);
            if (editSkillStatus.Item1 == "N")
            {
                Assert.Fail(editSkillStatus.Item2);
            }
        }

        [When(@"I clicked delete button of the skill '([^']*)' i want to delete")]
        public void WhenIClickedDeleteButtonOfTheSkillIWantToDelete(string skillToBeDeleted)
        {
            String deleteStatus = ProfilePageObj.DeleteSkill(skillToBeDeleted);
            if (deleteStatus != "")
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


    }
}

