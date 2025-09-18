using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace FFDTtestProj.Tests
{
    public class FantasyFootballTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Homepage_Should_Have_Correct_Title()
        {
            driver.Navigate().GoToUrl("https://brandonbjs.github.io/FFDT-gh-pages/");
            string expectedTitle = "Shaf's Fantasy Football Draft Tool";
            string actualTitle = driver.Title;

            ClassicAssert.AreEqual(expectedTitle, actualTitle);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}

