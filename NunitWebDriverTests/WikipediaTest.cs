using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitWebDriverTests
{
    public class WikipediaTest
    {
        private ChromeDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {

            this.driver = new ChromeDriver();
            driver.Url = "https://wikipedia.org";
            driver.Manage().Window.Maximize();

        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }

        [Test]
        public void Test_AssertMainPageTitle()
        {
            //Arrange
            var searchField = driver.FindElement(By.Id("searchInput"));
            string expectedUrl = "https://en.wikipedia.org/wiki/QA";

            //Act
            searchField.Click();
            searchField.SendKeys("QA" + Keys.Enter);

            //Assert
            Assert.AreEqual(expectedUrl, driver.Url);
        }
    }
}