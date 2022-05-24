using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace NunitWebDriverTests
{
    public class SoftUniTests
    {
        private ChromeDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArguments("--headless");

            this.driver = new ChromeDriver(options);
            driver.Url = "https://softuni.bg";
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
            //Act
            string expectedTitle = "Обучение по програмиране - Софтуерен университет";

            //Assert
            Assert.AreEqual(expectedTitle, driver.Title);
        }
    }
}