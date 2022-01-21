using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AutomationBetMan.BaseClass;

//extent report imports
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace AutomationBetMan.ObjectRepo.FootballObjects.Single 
{
    public class SpanishSinglePage : BaseTest
    {
        IWebDriver Driver;
        
        public SpanishSinglePage (IWebDriver driver)
        {
            Driver = driver;
        } 
        
        IWebElement footballGroupIcon => Driver.FindElement(By.Id("FootballGroup")); 
        IWebElement spanishSingleMatch => Driver.FindElement(By.Id("SpanishFastLeagueFootballSingleMatch"));

        //"Group" of single bet odd selection
        IWebElement xMROdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[5]/div/div/div[2]/div/div[1]/div/div[2]/div/span"));
        IWebElement firstAvailableDenominator => Driver.FindElement(By.Name("CurrencySymbol"));
        IWebElement submitBetSlip => Driver.FindElement(By.Id("submit-bet-slip"));

        //Group of Multiple bet odds
        IWebElement homeHTOdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[5]/div/div/div[2]/div/div[3]/div/div[1]/div/span"));
        IWebElement xHTOdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[7]/div/div/div[2]/div/div[3]/div/div[2]/div/span"));
        IWebElement awayHTOdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div[2]/div/div[9]/div/div/div[2]/div/div[3]/div/div[3]/div/span"));

        //Global for waiting for presence of an element
        //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //wait.Until(ExpectedConditions.ElementIsVisible(By.IdentifierHere("_______________")));

        //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //wait.Until(driver => Password.Displayed);
        
        //Functions
        public void PlaceSinglebet()
        {
            //add wait line
            Thread.Sleep(5000);
            footballGroupIcon.Click();
            Thread.Sleep(5000);
            spanishSingleMatch.Click();
            Thread.Sleep(5000);
            xMROdd.Click();
            firstAvailableDenominator.Click();
            Thread.Sleep(5000);
            submitBetSlip.Click();
        }
        
        public void PlaceMultiplebet()
        {
            //add wait line
            Thread.Sleep(5000);
            footballGroupIcon.Click();
            Thread.Sleep(5000);
            spanishSingleMatch.Click();
            Thread.Sleep(5000);
            homeHTOdd.Click();
            Thread.Sleep(5000);
            xHTOdd.Click();
            Thread.Sleep(5000);
            awayHTOdd.Click();
            Thread.Sleep(5000);
            submitBetSlip.Click();
        }
    }
}