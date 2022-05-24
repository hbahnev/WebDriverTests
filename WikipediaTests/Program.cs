using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Create new Chrome browser instance
var driver = new ChromeDriver();

// Navigate to Wikipedia
driver.Url = "https://wikipedia.org";

var searchField = driver.FindElement(By.Id("searchInput"));
searchField.Click();
searchField.SendKeys("QA" + Keys.Enter);

//Close browser
driver.Quit();
