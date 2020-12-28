using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace StackOverflowTest.Assambly
{
    public class Browsers
    {
        private static IWebDriver webDriver;
        private static string baseURL = "https://stackoverflow.com/";

        public static string Title => webDriver.Title;
        public static IWebDriver GetDriver => webDriver;

        public static void Init()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl(baseURL);
            webDriver.Manage().Window.Maximize();
        }
        public static void Close()
        {
            webDriver.Quit();
        }
        public static IWebElement GetWebElementByXPath(string XPath)
        {
            return  GetDriver.FindElement(By.XPath(XPath));
        }
    }
}