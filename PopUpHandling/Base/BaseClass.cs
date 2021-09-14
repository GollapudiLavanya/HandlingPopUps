using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PopUpHandling
{
    public class BaseClass
    {
        public String website_url = "http://the-internet.herokuapp.com/javascript_alerts";
        
        public IWebDriver driver;

        [SetUp]
        public void Start_Browser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("Start-Maximized");
            options.AddArgument("--disable-notification");
            options.AddArgument("--headless");

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(1000);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}