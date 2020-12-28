using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using StackOverflowTest.Assambly;

namespace StackOverflowTest.Pages
{
    public class StartPage
    {
        #region Locators

        //TODO: Реализовать локатор через атрибут FindsBy
        //[FindsBy(How = How.XPath, Using = "//a[@class = 'login-link s-btn s-btn__filled py8 js-gps-track']")]
        private static IWebElement LoginButton;

        #endregion
        #region Actions

        public static void Click()
        {
            //TODO: Передавать ссылки на элементы вне событий
            LoginButton = Browsers.GetWebElementByXPath("//a[@class = 'login-link s-btn s-btn__filled py8 js-gps-track']");
            LoginButton.Click();
        }

        #endregion
    }
}