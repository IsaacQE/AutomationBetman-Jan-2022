using NUnit.Framework;
using AutomationBetMan.BaseClass;
using AutomationBetMan.ObjectRepo.FootballObjects.Single;
using System.Threading;

namespace AutomationBetMan.TestCases.SingleFootball
{
    [TestFixture]
    public class MultipleBetPlacement : BaseTest
    {
        [Test]
        public void Test1Multiple()
        {
            var SpanishSinglePage = new SpanishSinglePage(driver);
            SpanishSinglePage.PlaceMultiplebet();
            Thread.Sleep(5000);
        }
    }
}
