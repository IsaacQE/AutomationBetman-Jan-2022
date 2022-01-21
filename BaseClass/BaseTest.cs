using NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationBetMan.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver(@"C:\betmanAuto\");
            driver.Manage().Window.Maximize();
            driver.Url = "https://games.staging.playbetman.com/?o=03f365b2-9081-4b15-8d4a-bd64a182ae14&p=ed05d48a-280d-41ce-bb56-d2f415f7e54f";
            //driver.Quit();
        }

        [TearDown]
        public void Close()
        {
            //Verify bet successfully placed message element & take screenshot
            IWebElement SuccessMessage = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/div/div[2]/nav/div[2]/div[1]/div/div/nav/section[1]/div")); 
            Boolean status = SuccessMessage.Displayed;
            Screenshot successMessageScreeshot = ((ITakesScreenshot)driver).GetScreenshot();
            successMessageScreeshot.SaveAsFile("C://AutomationBetMan//Image.png",
            ScreenshotImageFormat.Png);
            Console.WriteLine("Bet Successfully Placed message displayed");
            
            
            /*
            //take a screenshot
            Screenshot successMessageScreeshot = ((ITakesScreenshot)driver).GetScreenshot();
            successMessageScreeshot.SaveAsFile("C://AutomationBetMan//Image.png", 
            ScreenshotImageFormat.Png);
            */

            driver.Quit();
        }
        
    }
}