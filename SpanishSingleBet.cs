using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using SeleniumCSharpNetCore.Pages;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using System.Reflection;
using AutomationBetMan.BaseClass;
using AutomationBetMan.ObjectRepo.FootballObjects.Single;
using System.Threading;

namespace AutomationBetMan.TestCases.SingleFootball
{
    [TestFixture]
    public class SingleBetPlacement : BaseTest
    {
        [Test]
        public void Test1Single()
        {
            var SpanishSinglePage = new SpanishSinglePage(driver);
            SpanishSinglePage.PlaceSinglebet();
            Thread.Sleep(5000);
        }
    }
}
