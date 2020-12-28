using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using StackOverflowTest.Assambly;
using OpenQA.Selenium;

namespace StackOverflowTest.Pages
{
    public class AuthorizationPage
    {
        #region Locators

        //TODO: Реализовать локатор через атрибут FindsBy
        private static IWebElement EmailInput;
        private static IWebElement PassInput;
        private static IWebElement SubmitButton;

        #endregion
        #region Actions

        public static void Autorization()
        {
            //TODO: Передавать ссылки на элементы вне событий
            EmailInput = Browsers.GetWebElementByXPath("//input[@id='email']");
            PassInput = Browsers.GetWebElementByXPath("//input[@id='password']");
            SubmitButton = Browsers.GetWebElementByXPath("//button[@id='submit-button']");
            EmailInput.SendKeys("mr-ra@live.ru");
            PassInput.SendKeys("011235Sof");
            SubmitButton.Click();
        }

        #endregion
    }
}