using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.Pages
{
    public class SignIn : Driver
    {
        public void LoginSteps()
        {
            NavigateUrl();
            driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();
            driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("testdata@gmail.com");
            driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("123123");
            driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
        }
    }
}