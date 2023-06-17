using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.Pages
{
    public class SignIn
    {
        public void SignInSteps()
        {
            Driver.NavigateUrl();
        }
        public void LoginSteps()
        {
            Driver.NavigateUrl();

            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("testdata@gmail.com");

            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("123123");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        }
    }
}