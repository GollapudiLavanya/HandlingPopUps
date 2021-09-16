/*
 * project = PopUpHandling
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PopUpHandling.Base
{
    public class BaseClass
    {
        public static IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("Start-Maximized");
            options.AddArgument("--disable-notification");
            options.AddArgument("--headless");

            driver = new ChromeDriver();
            driver.Url = "http://the-internet.herokuapp.com/javascript_alerts";
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(1000);
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}
