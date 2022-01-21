using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AutomationBetMan.BaseClass;

namespace AutomationBetMan.ObjectRepo.FootballObjects.League

{
    public class SoccerbetEnglishLeaguePage : BaseTest
    {
        IWebDriver Driver;
        
        public SoccerbetEnglishLeaguePage (IWebDriver driver)
        {
            Driver = driver;
        } 

        IWebElement footballGroupIcon => Driver.FindElement(By.Id("FootballGroup"));
        IWebElement soccerBetEnglishLeagueMatch => Driver.FindElement(By.Id("EnglishPreRecFootballLeagueRound"));
        IWebElement homeDCOdd => Driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[1]/div/div/nav/div[6]/div[2]/div/div/div/div[6]/section/div[2]/div[2]/div/div[1]/div/div/div[2]/div/div[2]/div/div[1]/div/span"));
        IWebElement firstAvailableDenominator => Driver.FindElement(By.Name("CurrencySymbol"));
        IWebElement submitBetSlip => Driver.FindElement(By.Id("submit-bet-slip"));

        public void PlaceSinglebetSEL()
        {
            Thread.Sleep(5000);
            footballGroupIcon.Click();
            Thread.Sleep(5000);
            soccerBetEnglishLeagueMatch.Click();
            Thread.Sleep(5000);
            homeDCOdd.Click();
            Thread.Sleep(5000);
            firstAvailableDenominator.Click();
            Thread.Sleep(5000);
            submitBetSlip.Click();
        }
    }
}