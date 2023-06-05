using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RazorEngine;
using System;
using System.Collections.Generic;


namespace MarsQA_1.SpecflowPages.Pages
{
    public class ProfilePage
    {
        public void ClickEditDescription()
        {
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")).Click();
        }
        
        public void EnterDescription(String description)
        {
            Driver.driver.FindElement(By.Name("value")).Clear();
            Driver.driver.FindElement(By.Name("value")).SendKeys(description);
        }
        
        public void ClickSaveDescription()
        {
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")).Click();
        }
        
        public bool ValidateDescription(String description)
        {
            IWebElement actualDescription = Driver.driver.FindElement(By.Name("value"));
            if (actualDescription.Text == description)
            {
                return true;
            }
            return false;
        }
        
        public void ClickEditName()
        {
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i")).Click();
        }
        
        public void EnterNames(string firstname, string lastname)
        {
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.Name("firstName")).Clear();
            Driver.driver.FindElement(By.Name("firstName")).SendKeys(firstname);
            Driver.driver.FindElement(By.Name("lastName")).Clear();
            Driver.driver.FindElement(By.Name("lastName")).SendKeys(lastname);
        }
        
        public void ClickSaveName()
        {
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button")).Click();
        }
        
        public bool ValidateName(string firstname, string lastname)
        {
            Driver.TurnOnWait();
            IWebElement actualFullName = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
            String fullName = firstname +" "+ lastname;
            if (actualFullName.Text == fullName)
            {
                return true;
            }
            return false;
        }
       
        public void ClickEditAvailability()
        {
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")).Click();
        }
      
        public void SelectAvailability(string availability)
        {
            SelectElement SelectAvailability = new SelectElement(Driver.driver.FindElement(By.Name("availabiltyType")));
            SelectAvailability.SelectByText(availability);
        }
      
        public bool ValidateAvailability(string availability)
        {
            Driver.TurnOnWait();
            IWebElement actualAvailability = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            if (actualAvailability.Text == availability)
            {
                return true;
            }
            return false;
        }
      
        public void ClickEditHours()
        {
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")).Click();
        }
       
        public void SelectHours(string hours)
        {
            Console.WriteLine("passed hours " + hours);
           // Console.WriteLine("actualHours.Text " + actualHours.Text);


            SelectElement SelectHours = new SelectElement(Driver.driver.FindElement(By.Name("availabiltyHour")));
            SelectHours.SelectByText(hours);
        }
      
        public bool ValidateHours(string hours)
        {
            Driver.TurnOnWait();
            IWebElement actualHours = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            if (actualHours.Text == hours)
            {
                return true;
            }
            return false;
        }

        public void ClickEditEarnTarget()
        {
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")).Click();
        }

        public void SelectEarnTarget(string earnTarget)
        {
            SelectElement SelectEarnTarget = new SelectElement(Driver.driver.FindElement(By.Name("availabiltyTarget")));
            SelectEarnTarget.SelectByText(earnTarget);
        }

        public bool ValidateEarnTarget(string earnTarget)
        {
            Driver.TurnOnWait();
            IWebElement actualEarnTarget = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span"));
            if (actualEarnTarget.Text == earnTarget)
            {
                return true;
            }
            return false;
        }

        public void GoToLanguageTab()
        {
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();
        }

        public bool IsDisplayed()
        {
            Boolean flag = false;
            try
            {
                Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
                Boolean isElementPresent = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Displayed;
                if (isElementPresent)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
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
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
        }

        public void EnterNewLanguage(String language, String level)
        {
            Driver.TurnOnWait();

            IWebElement languageTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));

            List<IWebElement> allLanguageRow = new List<IWebElement>(languageTable.FindElements(By.TagName("tbody")));

            if (allLanguageRow.Count < 4)
            {
                IWebElement newLanguage = Driver.driver.FindElement(By.Name("name"));
                newLanguage.SendKeys(language);

                SelectElement SelectLanguage = new SelectElement(Driver.driver.FindElement(By.Name("level")));
                SelectLanguage.SelectByText(level);
            }
        }

        public void AddLanguageButton()
        {
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();
        }

        public (String, String) ValidateNewLanguage(String validateLanguage, String validateLevel)
        {
            Driver.TurnOnWait();
            String newLangaugeMessage = "";
            String newLangaugeStatus = "N";
            IWebElement languageTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            List<IWebElement> allLanguageRow = new List<IWebElement>(languageTable.FindElements(By.TagName("tbody")));
            
            IWebElement LastTableLanguage = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));       
            IWebElement LastTableLanguageLevel = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

            IWebElement addButtonLanguage = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Boolean isElementPresent = addButtonLanguage.Displayed;
            if (isElementPresent)
            {
                if ((LastTableLanguage.Text == validateLanguage) && (LastTableLanguageLevel.Text == validateLevel))
                {
                    newLangaugeMessage = "Added to the table";
                    newLangaugeStatus = "Y";
                }
                else
                {
                    newLangaugeStatus = "N";
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
                            newLangaugeMessage = "Duplicate data";
                            break;
                        }
                        else {
                            newLangaugeMessage = "Undefined error";
                        }
                    }
                }
            }
            else
            {
                newLangaugeStatus = "N";
                newLangaugeMessage = "List has already four language.";
            }
            return (InsertStatus: newLangaugeStatus, InsertMessage: newLangaugeMessage);
        }
       
        public void EditLanguage(string editLanguage)
        {
            IWebElement editButton = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editButton.Click();
            /*String editStatus = "";
            IWebElement languageTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            List<IWebElement> allLanguageRow = new List<IWebElement>(languageTable.FindElements(By.TagName("tbody")));
            foreach (var row in allLanguageRow)
            {
                var resultCols = row.FindElements(By.TagName("td"));

                if (resultCols[0].Text == editLanguage)
                {
                    List<IWebElement> allIconsRow = new List<IWebElement>(row.FindElements(By.TagName("i")));
                    foreach (var icon in allIconsRow)
                    {
                        if (icon.GetAttribute("class") == "outline write icon")
                        {
                            Console.WriteLine(icon.GetAttribute("class"));
                            try
                            {
                                icon.Click();
                                editStatus = "";
                            }
                            catch (StaleElementReferenceException e)
                            {
                                Console.WriteLine("StaleElementReferenceException " +e);
                            }

                        }
                        else
                        {
                            editStatus = "Undefined Error";
                        }
                    }
                }
                else
                {
                    editStatus = "The language intented to edit is not in the list";
                }
            }*/
        }
               
        public void EnterEditLanguage(String editLanguage, String editLanguageLevel)
        {
            IWebElement newLanguage = Driver.driver.FindElement(By.Name("name"));
            newLanguage.Clear();
            newLanguage.SendKeys(editLanguage);

            SelectElement SelectLanguage = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            SelectLanguage.SelectByText(editLanguageLevel);
        }

        public void UpdateLanguageButton()
        {
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.XPath("//input[contains(@class,'ui teal button')]")).Click();
        }

        public (String,String) ValidateUpdatedLanguage(String updatedLanguage, String updatedLanguageLevel)
        {

            Driver.TurnOnWait();
            String editLangaugeMessage = "";
            String editLangaugeStatus = "N";
            IWebElement languageTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
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
                    editLangaugeStatus = "N";
                    editLangaugeMessage = "Language Updation failed";
                }
            }
            return (InsertStatus: editLangaugeStatus, InsertMessage: editLangaugeMessage);
        }

        public String DeleteLanguage(String LanguageToDelete)
        {
            String deleteStatus = "";
            IWebElement languageTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
            List<IWebElement> allLanguageRow = new List<IWebElement>(languageTable.FindElements(By.TagName("tbody")));
            foreach (var row in allLanguageRow)
            {
                var resultCols = row.FindElements(By.TagName("td"));
                Driver.TurnOnWait();

                if (resultCols[0].Text == LanguageToDelete)
                {
                    List<IWebElement> allIconsRow = new List<IWebElement>(row.FindElements(By.TagName("i")));
                    foreach (var icon in allIconsRow)
                    { 
                        if(icon.GetAttribute("class") == "remove icon")
                        {
                            Driver.TurnOnWait();
                            icon.Click();
                            deleteStatus = "";
                        }
                        else
                        {
                            deleteStatus = "Undefined Error";
                        }
                    }
                }
                else
                {
                    deleteStatus = "The language intented to delete is not in the list";
                }
            }
            return(deleteStatus);
        }

        public (String, String) ValidateDeletion(String deleteLanguage)
        {
            String deletionStatus = "";
            String deletionMessage = "";
            IWebElement languageTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
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
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        }

        public void AddNewSkillButton()
        {
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();
            
        }

        public void EnterNewSkill(String skill, String skillLevel)
        {
            Driver.TurnOnWait();

            IWebElement newLanguage = Driver.driver.FindElement(By.Name("name"));
            newLanguage.SendKeys(skill);

            SelectElement SelectLanguage = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            SelectLanguage.SelectByText(skillLevel);
        }

        public void AddSkillButton()
        {
            Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")).Click();
        }

        public (String, String) ValidateNewSkill(string validateSkill, string validateSkillLevel)
        {

            Driver.TurnOnWait();
            String AddNewSkillStatus = "";
            String AddNewSkillMessage = "";

            IWebElement skillTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
            List<IWebElement> allSkillRow = new List<IWebElement>(skillTable.FindElements(By.TagName("tbody")));

            IWebElement LastTableSkill = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement LastTableSkillLevel = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));

            if ((LastTableSkill.Text == validateSkill) && (LastTableSkillLevel.Text == validateSkillLevel))
            {
                AddNewSkillMessage = "Added to the table";
                AddNewSkillStatus = "Y";
            }
            else
            {
                AddNewSkillStatus = "N";
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

        public void EditSkill(string skillToBeEdited)
        {
            IWebElement editButton = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            editButton.Click();

            /*String editStatus = "";
            IWebElement languageTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
            List<IWebElement> allLanguageRow = new List<IWebElement>(languageTable.FindElements(By.TagName("tbody")));
            foreach (var row in allLanguageRow)
            {
                var resultCols = row.FindElements(By.TagName("td"));
                if (resultCols[0].Text == skillToBeEdited)
                {
                    List<IWebElement> allIconsRow = new List<IWebElement>(row.FindElements(By.TagName("i")));
                    foreach (var icon in allIconsRow)
                    {
                        if (icon.GetAttribute("class") == "outline write icon")
                        {
                            editStatus = "";
                            icon.Click();
                        }
                    else
                    {
                            editStatus = "Undefined Error";
                    }
                    }
                    }
                    }*/
        }

        public void EnterEditSkill(string editSkill, string editSkillLevel)
        {
            IWebElement editedSkill = Driver.driver.FindElement(By.Name("name"));
            editedSkill.Clear();
            editedSkill.SendKeys(editSkill);

            SelectElement editedSkilllevel = new SelectElement(Driver.driver.FindElement(By.Name("level")));
            editedSkilllevel.SelectByText(editSkillLevel);
        }
        public void UpdateSkillButton()
        {
            Driver.TurnOnWait();
            Driver.driver.FindElement(By.XPath("//input[contains(@class,'ui teal button')]")).Click();
        }

        public (String, String) ValidateUpdatedSkill(string editSkill, string editSkillLevel)
        {
            Driver.TurnOnWait();
            String editSkillMessage = "";
            String editSkillStatus = "N";
            IWebElement skillTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table"));
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
                    editSkillStatus = "N";
                    editSkillMessage = "Skill Updation failed";
                    break;
                }
            }
            return (EditStatus: editSkillMessage, EditMessage: editSkillMessage);
        }
             
        public string DeleteSkill(string skillToBeDeleted)
        {
            //Driver.TurnOnWait();
            String deleteStatus = "";
            IWebElement languageTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
            List<IWebElement> allLanguageRow = new List<IWebElement>(languageTable.FindElements(By.TagName("tbody")));
            foreach (var row in allLanguageRow)
            {
                var resultCols = row.FindElements(By.TagName("td"));
                if (resultCols[0].Text == skillToBeDeleted)
                {
                    List<IWebElement> allIconsRow = new List<IWebElement>(row.FindElements(By.TagName("i")));
                    foreach (var icon in allIconsRow)
                    {
                        if (icon.GetAttribute("class") == "remove icon")
                        {
                            Driver.TurnOnWait();
                            icon.Click();
                            deleteStatus = "";
                        }
                        else
                        {
                            deleteStatus = "Undefined Error";
                        }
                    }
                }
                else
                {
                    deleteStatus = "The skill intented to delete is not in the list";
                }
            }
            return (deleteStatus);
        }

        public (String, String) ValidateSkillDeletion(string skillToBeDeleted)
        {
            String deletionSkillStatus = "N";
            String deletionSkillMessage = "";
            IWebElement skillTable = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table"));
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
