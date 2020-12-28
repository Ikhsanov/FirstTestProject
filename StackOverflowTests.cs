using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using StackOverflowTest.Pages;
using StackOverflowTest.Assambly;
using System.Threading;

namespace StackOverflowTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Browsers.Init();
        }

        [Test]
        public void Test1()
        {
            StartPage.Click();
            AuthorizationPage.Autorization();
            Thread.Sleep(400);
            HomePage.Search();
            Thread.Sleep(400);
            HomePage.GoToLink();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}