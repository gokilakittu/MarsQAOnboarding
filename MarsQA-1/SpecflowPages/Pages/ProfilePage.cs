using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;


namespace MarsQA_1.SpecflowPages.Pages
{
    public class ProfilePage : Driver
    {
        public void ClickEditDescription()
        {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")).Click();
        }
        
        public void EnterDescription(String description)
        {
            driver.FindElement(By.Name("value")).Clear();
            driver.FindElement(By.Name("value")).SendKeys(description);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();
            TurnOnWait();
        }
               
        public bool ValidateDescription(String description)
        {
            bool ValidateAvailability ;
            TurnOnWait();
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            if (actualDescription.Text == description)
            {
                ValidateAvailability = true;
            }
            else
            {
                ValidateAvailability = false;
            }
            return ValidateAvailability;
        }
        
        public void ClickEditName()
        {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i")).Click();
        }
        
        public void EnterNames(string firstname, string lastname)
        {
            TurnOnWait();
            driver.FindElement(By.Name("firstName")).Clear();
            driver.FindElement(By.Name("firstName")).SendKeys(firstname);
            driver.FindElement(By.Name("lastName")).Clear();
            driver.FindElement(By.Name("lastName")).SendKeys(lastname);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button")).Click();

        }
                
        public bool ValidateName(string firstname, string lastname)
        {
            bool ValidateName;
            TurnOnWait();
            IWebElement actualFullName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
            String fullName = firstname +" "+ lastname;
            if (actualFullName.Text == fullName)
            {
                ValidateName = true;
            }
            else
            {
                ValidateName = false;
            }
            return ValidateName;
        }
       
        public void ClickEditAvailability()
        {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")).Click();
        }
      
        public void SelectAvailability(string availability)
        {
            SelectElement SelectAvailability = new SelectElement(driver.FindElement(By.Name("availabiltyType")));
            SelectAvailability.SelectByText(availability);
        }
      
        public bool ValidateAvailability(string availability)
        {
            bool ValidateAvailability;
            TurnOnWait();
            IWebElement actualAvailability = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            if (actualAvailability.Text == availability)
            {
                 ValidateAvailability = true;
            }
            else
            {
                ValidateAvailability = false;
            }
            return ValidateAvailability;
        }
      
        public void ClickEditHours()
        {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")).Click();
        }
       
        public void SelectHours(string hours)
        {
            SelectElement SelectHours = new SelectElement(driver.FindElement(By.Name("availabiltyHour")));
            SelectHours.SelectByText(hours);
        }
      
        public bool ValidateHours(string hours)
        {
            bool ValidateHours;
            TurnOnWait();
            IWebElement actualHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            if (actualHours.Text == hours)
            {
                 ValidateHours = true;
            }
            else
            {
                ValidateHours = false;
            }
            return ValidateHours;
        }

        public void ClickEditEarnTarget()
        {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")).Click();
        }

        public void SelectEarnTarget(string earnTarget)
        {
            SelectElement SelectEarnTarget = new SelectElement(driver.FindElement(By.Name("availabiltyTarget")));
            SelectEarnTarget.SelectByText(earnTarget);
        }

        public bool ValidateEarnTarget(string earnTarget)
        {
            bool ValidateEarnTarget;
            TurnOnWait();
            IWebElement actualEarnTarget = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
            if (actualEarnTarget.Text == earnTarget)
            {
                ValidateEarnTarget = true;
            }
            else
            {
                ValidateEarnTarget = false;
            }
            return ValidateEarnTarget;
        }

        /*if the table has more than 4 language the add button will be hiden*/
        public bool ClickAddNewLanguage()
        {
            Boolean flag = false;
            try
            {
                Boolean isAddButtonPresent = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Displayed;
                if (isAddButtonPresent)
                {
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                if (ex is NoSuchElementException)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public void AddNewLanguageButton()
        {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
        }

        public void EnterNewLanguage(String language, String level)
        {
            TurnOnWait();
            IWebElement languageTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            List<IWebElement> allLanguageRow = new List<IWebElement>(languageTable.FindElements(By.TagName("tbody")));
            if (allLanguageRow.Count < 4)
            {
                EnterValuesLanguage(language,level);
                driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
             }
        }

        public void EnterValuesLanguage(String language, String level)
        {
            IWebElement newLanguage = driver.FindElement(By.Name("name"));
            newLanguage.Clear();
            newLanguage.SendKeys(language);

            SelectElement SelectLanguage = new SelectElement(driver.FindElement(By.Name("level")));
            Driver.TurnOnWait();
            SelectLanguage.SelectByText(level);
        }

        public (String, String) ValidateNewLanguage(String validateLanguage, String validateLevel)
        {
            TurnOnWait();
            String newLangaugeMessage = "";
            String newLangaugeStatus = "N";
            IWebElement languageTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            List<IWebElement> allLanguageRow = new List<IWebElement>(languageTable.FindElements(By.TagName("tbody")));
            
            IWebElement LastTableLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));       
            IWebElement LastTableLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

            IWebElement addButtonLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Boolean isElementPresent = addButtonLanguage.Displayed;
            TurnOnWait();
            if (isElementPresent)
            {
                if ((LastTableLanguage.Text == validateLanguage) && (LastTableLanguageLevel.Text == validateLevel))
                {
                    newLangaugeMessage = "Added to the table";
                    newLangaugeStatus = "Y";
                }
                else
                {
                    foreach (var row in allLanguageRow)
                    {
                        var resultCols = row.FindElements(By.TagName("td"));
                        if ((resultCols[0].Text == validateLanguage) && (resultCols[1].Text == validateLevel))
                        {
                            newLangaugeMessage = "Language already exist in the list";
                            break;
                        }
                        else if ((resultCols[0].Text == validateLanguage) && (resultCols[1].Text != validateLevel))
                        {
                            newLangaugeMessage = "Language already present with different level";
                            break;
                        }
                        else {
                            newLangaugeMessage = "Language was not added with undefined error";
                        }
                    }
                }
            }
            else
            {
                newLangaugeMessage = "List has already four language.";
            }
            return (InsertStatus: newLangaugeStatus, InsertMessage: newLangaugeMessage);
        }
                       
        public void EnterEditLanguage(String languageToBeEdited, String editLanguage, String editLanguageLevel)
        {
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editButton.Click();
            EnterValuesLanguage(editLanguage, editLanguageLevel);
            driver.FindElement(By.XPath("//input[contains(@class,'ui teal button')]")).Click();
        }
        
        public (String,String) ValidateUpdatedLanguage(String updatedLanguage, String updatedLanguageLevel)
        {
            TurnOnWait();
            String editLangaugeMessage = "";
            String editLangaugeStatus = "N";
            IWebElement languageTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            List<IWebElement> allLanguageRow = new List<IWebElement>(languageTable.FindElements(By.TagName("tbody")));
            
            foreach (var row in allLanguageRow)
            {
                var resultCols = row.FindElements(By.TagName("td"));
                if (resultCols[0].Text == updatedLanguage)
                {
                    editLangaugeStatus = "Y";
                    editLangaugeMessage = "Language Updated successfully";
                    break;
                }
                else
                {
                    editLangaugeMessage = "Language Updation failed";
                }
            }
            return (InsertStatus: editLangaugeStatus, InsertMessage: editLangaugeMessage);
        }

        public String DeleteLanguage(String LanguageToDelete)
        {
            TurnOnWait();
            String deleteStatus = "";
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteButton.Click();
            return(deleteStatus);
        }

        public (String, String) ValidateDeletion(String deleteLanguage)
        {
            String deletionStatus = "N";
            String deletionMessage = "";
            IWebElement languageTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            List<IWebElement> allLanguageRow = new List<IWebElement>(languageTable.FindElements(By.TagName("tbody")));

            foreach (var row in allLanguageRow)
            {
                var resultCols = row.FindElements(By.TagName("td"));
                if (resultCols[0].Text != deleteLanguage)
                {
                    deletionStatus = "Y";
                    deletionMessage = "Deletion Successful";
                }
            }
            return (DeletionStatus: deletionStatus, DeletionMessage: deletionMessage);
        }

        public void GoToSkillTab()
        {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        }
                
        public void EnterNewSkill(String skill, String skillLevel)
        {
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            TurnOnWait();
            IWebElement newLanguage = driver.FindElement(By.Name("name"));
            newLanguage.SendKeys(skill);
            SelectElement SelectLanguage = new SelectElement(driver.FindElement(By.Name("level")));
            SelectLanguage.SelectByText(skillLevel);
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
        }
        
        public (String, String) ValidateNewSkill(string validateSkill, string validateSkillLevel)
        {
            TurnOnWait();
            String AddNewSkillStatus = "N";
            String AddNewSkillMessage = "";

            IWebElement skillTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
            List<IWebElement> allSkillRow = new List<IWebElement>(skillTable.FindElements(By.TagName("tbody")));

            IWebElement LastTableSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement LastTableSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

            if ((LastTableSkill.Text == validateSkill) && (LastTableSkillLevel.Text == validateSkillLevel))
            {
                AddNewSkillMessage = "Added to the table";
                AddNewSkillStatus = "Y";
            }
            else
            {
                foreach (var row in allSkillRow)
                {
                    var resultCols = row.FindElements(By.TagName("td"));

                    if ((resultCols[0].Text == validateSkill) && (resultCols[1].Text == validateSkillLevel))
                    {
                        AddNewSkillMessage = "Skill already exist in the list";
                        break;
                    }
                    else if ((resultCols[0].Text == validateSkill) && (resultCols[1].Text != validateSkillLevel))
                    {
                        AddNewSkillMessage = "Duplicate data";
                        break;
                    }
                    else
                    {
                        AddNewSkillMessage = "Undefined error";
                    }
                }
            }
        return (InsertSkillStatus: AddNewSkillStatus, InsertSkillMessage: AddNewSkillMessage);
        }
       
        public void EnterEditSkill(String skillToBeEdited,string editSkill, string editSkillLevel)
        {
            TurnOnWait();
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editButton.Click();
            IWebElement editedSkill = driver.FindElement(By.Name("name"));
            editedSkill.Clear();
            editedSkill.SendKeys(editSkill);

            SelectElement editedSkilllevel = new SelectElement(driver.FindElement(By.Name("level")));
            editedSkilllevel.SelectByText(editSkillLevel);
            TurnOnWait();
            driver.FindElement(By.XPath("//input[contains(@class,'ui teal button')]")).Click();
        }
        
        public (String, String) ValidateUpdatedSkill(string editSkill, string editSkillLevel)
        {
            TurnOnWait();
            String editSkillMessage = "";
            String editSkillStatus = "N";
            IWebElement skillTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
            List<IWebElement> allSkillRow = new List<IWebElement>(skillTable.FindElements(By.TagName("tbody")));

            foreach (var row in allSkillRow)
            {
                var resultCols = row.FindElements(By.TagName("td"));
                if ((resultCols[0].Text == editSkill) && (resultCols[1].Text == editSkillLevel))
                {
                     editSkillStatus = "Y";
                    editSkillMessage = "Skill Updated successfully";
                    break;
                }
                else
                {
                    editSkillMessage = "Skill Updation failed";
                    break;
                }
            }
            return (EditStatus: editSkillStatus, EditMessage: editSkillMessage);
        }
             
        public string DeleteSkill(string skillToBeDeleted)
        {
            String deleteStatus = "";
            TurnOnWait();
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
            deleteButton.Click();
            return (deleteStatus);
        }

        public (String, String) ValidateSkillDeletion(string skillToBeDeleted)
        {
            String deletionSkillStatus = "N";
            String deletionSkillMessage = "";
            IWebElement skillTable = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
            List<IWebElement> allSkillRow = new List<IWebElement>(skillTable.FindElements(By.TagName("tbody")));
            foreach (var row in allSkillRow)
            {
                var resultCols = row.FindElements(By.TagName("td"));
                if (resultCols[0].Text != skillToBeDeleted)
                {
                    deletionSkillStatus = "Y";
                    deletionSkillMessage = "Deletion Successful";
                }
            }
            return (DeletionSkillStatus: deletionSkillStatus, DeletionSkillMessage: deletionSkillMessage);
        }
    }
}
