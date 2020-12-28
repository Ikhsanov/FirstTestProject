using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using StackOverflowTest.Assambly;

namespace StackOverflowTest.Pages
{
    public  class HomePage
    {
        #region Locators

        //TODO: Реализовать локатор через атрибут FindsBy
        private static IWebElement SearchInput;
        private static IWebElement SearchLink;

        #endregion
        #region Actions

        public static void Search()
        {
            //TODO: Передавать ссылки на элементы вне событий
            SearchInput = Browsers.GetWebElementByXPath("//input[@name = 'q']");
            SearchInput.SendKeys("Selenium");
            SearchInput.Submit();
        }

        public static void GoToLink()
        {
            //TODO: Передавать ссылки на элементы вне событий
            SearchLink = Browsers.GetWebElementByXPath("/html/body/div[3]/div[2]/div[1]/div[5]/div[1]/div[2]/h3/a");
            SearchLink.Click();
        }

        #endregion
    }
}

