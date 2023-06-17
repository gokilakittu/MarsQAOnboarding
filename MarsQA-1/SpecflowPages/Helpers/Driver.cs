﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class Driver
    {
        //Initialize the browser
        public static IWebDriver driver;

        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();
            TurnOnWait();
            
            //Maximise the window
            driver.Manage().Window.Maximize();
        }

        public static string BaseUrl
        {
            get { return ConstantHelpers.Url; }
        }

        //Implicit Wait
        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Thread.Sleep(2000);
        }

        public static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        //Close the browser
        public void Close()
        {
            driver.Quit();
        }

    }
}
