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
    public class LanguageFeatureStepDefinitions: Driver
    {
        LoginPage LoginPageObj = new LoginPage();
        ProfilePage ProfilePageObj = new ProfilePage();

        [Given(@"I logged into the mars successfully")]
        public void GivenILoggedIntoTheMarsSuccessfully()
        {
            if (LoginPageObj.ConfirmUser() == false)
            {
                Assert.Fail("The was a session error");
            }
        }

        [When(@"I am in the language tab")]
        public void WhenIAmInTheLanguageTab()
        {
            ProfilePageObj.GoToLanguageTab();
        }

        [When(@"I clicked add new button in language tab")]
        public void WhenIClickedAddNewButtonInLanguageTab()
        {
            if (ProfilePageObj.IsDisplayed()==true)
            {
                ProfilePageObj.AddNewLanguageButton();
            }
            else {
                Assert.Fail("List has already four language. Please delete a language to add another.");
            }
        }

        [When(@"I entered the '([^']*)' '([^']*)' to add language")]
        public void WhenIEnteredTheToAddLanguage(string language, string level)
        {
            if (ProfilePageObj.IsDisplayed() == true)
            {
                ProfilePageObj.EnterNewLanguage(language, level);
            }
            else
            {
                Assert.Fail("List has already four language. Please delete a language to add another.");
            }
        }

        [When(@"I clicked add button to add language")]
        public void WhenIClickedAddButtonToAddLanguage()
        {
            if (ProfilePageObj.IsDisplayed() == true)
            {
                ProfilePageObj.AddLanguageButton();
            }
            else
            {
                Assert.Fail("List has already four language. Please delete a language to add another.");
            }
        }

        [Then(@"the new '([^']*)''([^']*)' was successfully created")]
        public void ThenTheNewWasSuccessfullyCreated(string validateLanguage, string validateLevel)
        {
            var newLangaugeStatus = ProfilePageObj.ValidateNewLanguage(validateLanguage, validateLevel);
                
            if (newLangaugeStatus.Item1 == "N")
            {
                Assert.Fail(newLangaugeStatus.Item2);
            }
            
        }
        [When(@"I click the edit button of the '([^']*)' i want to edit")]
        public void WhenIClickTheEditButtonOfTheIWantToEdit(string languageToBeEdited)
        {
            ProfilePageObj.EditLanguage(languageToBeEdited);
        }

        [When(@"I entered the '([^']*)' '([^']*)' to edit '([^']*)' language")]
        public void WhenIEnteredTheToEditLanguage(string editLanguage, string editLanguageLevel, string languageToBeEdited)
        {
            ProfilePageObj.EnterEditLanguage(editLanguage, editLanguageLevel);
        }

        [When(@"I clicked update button to edit language")]
        public void WhenIClickedUpdateButtonToEditLanguage()
        {
            ProfilePageObj.UpdateLanguageButton();
        }

        [Then(@"The language was successfully updated with '([^']*)''([^']*)'")]
        public void ThenTheLanguageWasSuccessfullyUpdatedWith(string updatedLanguage, string updatedLanguageLevel)
        {
            var editLangaugeStatus = ProfilePageObj.ValidateUpdatedLanguage(updatedLanguage,updatedLanguageLevel);
            if (editLangaugeStatus.Item1 == "N")
            {
                Assert.Fail(editLangaugeStatus.Item2);
            }
        }

        [When(@"I clicked delete button of the '([^']*)' i want to delete")]
        public void WhenIClickedDeleteButtonOfTheIWantToDelete(String deleteLanguage)
        {
            String deleteStatus = ProfilePageObj.DeleteLanguage(deleteLanguage);
            if(deleteStatus != "")
            {
                Assert.Fail(deleteStatus);
            }
        }
        

        [Then(@"the '([^']*)' language was deleted successfully")]
        public void ThenTheLanguageWasDeletedSuccessfully(String deleteLanguage)
        {
            var deletionStatus = ProfilePageObj.ValidateDeletion(deleteLanguage);
            if (deletionStatus.Item1 == "N")
            {
                Assert.Fail(deletionStatus.Item2);
            }
        }
    }
}
