using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class LoginPage
    {
		public bool ConfirmUser()
		{
            bool ValidateAvailability = false;
            Driver.TurnOnWait();
            IWebElement currentUser = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
			if (currentUser.Text != null)
			{
                ValidateAvailability = true;
			}
			return ValidateAvailability;
		}
    }
}
