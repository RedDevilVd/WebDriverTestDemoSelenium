using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Create new Chrome broeser instances
var driver = new ChromeDriver();

//Navigate to Wikipedia
driver.Url = "https://wikipedia.org";

Console.WriteLine("CURRENT TITLE:  " + driver.Title);

//locate search field
var searchField = driver.FindElement(By.Id("searchInput"));
searchField.Click();
searchField.SendKeys("QA" + Keys.Enter);

Console.WriteLine("TITLE AFTER SEARCH :  " + driver.Title);

//Close browser
driver.Quit();

