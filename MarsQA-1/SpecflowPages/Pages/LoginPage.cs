﻿using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class LoginPage:Driver
    {
        public bool ConfirmUser()
        {
            bool ValidateAvailability = false;
            TurnOnWait();
            IWebElement currentUser = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
            if (currentUser.Text != null)
            {
                ValidateAvailability = true;
            }
            return ValidateAvailability;
        }
    }
}