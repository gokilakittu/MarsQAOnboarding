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
			IWebElement currentUser = Driver.driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
			if (currentUser.Text != null)
			{
				return true;
			}
			return false;
		}
             /*
             static void Main(string[] args)
		{
			// Open the browser for Automation
			IWebDriver driver = new FirefoxDriver();
			driver.Manage().Window.Maximize();

			// WebPage which contains a WebTable
			driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites");
			driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));

			// xpath of html table
			var elemTable =	driver.FindElement(By.XPath("//div[@id='mw-content-text']//table[1]"));

			// Fetch all Row of the table
			List<IWebElement> lstTrElem = new List<IWebElement>(elemTable.FindElements(By.TagName("tr")));
			String strRowData = "";

			// Traverse each row
			foreach (var elemTr in lstTrElem)
			{
				// Fetch the columns from a particuler row
				List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
				if (lstTdElem.Count > 0)
				{
					// Traverse each column
					foreach (var elemTd in lstTdElem)
					{
						// "\t\t" is used for Tab Space between two Text
						strRowData = strRowData + elemTd.Text + "\t\t";
					}
				}
				else
				{
					// To print the data into the console
					Console.WriteLine("This is Header Row");
					Console.WriteLine(lstTrElem[0].Text.Replace(" ", "\t\t"));
				}
				Console.WriteLine(strRowData);
				strRowData = String.Empty;
			}
			Console.WriteLine("");
			driver.Quit();
		}
             
             */
     
    }
}
