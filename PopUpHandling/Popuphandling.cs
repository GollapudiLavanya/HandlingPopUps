using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace PopUpHandling
{
    public class popuphandling : BaseClass
    {
        [Test, Order(0)]
        public void AlertTest()
        {
            String button_xpath = "//button[.='Click for JS Alert']";
            var expectedAlertText = "I am a JS Alert";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Url = website_url;
            System.Threading.Thread.Sleep(1000);

            IWebElement alertButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(button_xpath)));
            System.Threading.Thread.Sleep(1000);
            alertButton.Click();

            var alert_win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, alert_win.Text);
            System.Threading.Thread.Sleep(5000);

            alert_win.Accept();


            var clickResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("result")));



            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You successfuly clicked an alert")
            {
                Console.WriteLine("Alert Test Successful");
            }
        }
        [Test, Order(1)]
        public void Confirm_Test()
        {
            String button_css_selector = "button[onclick='jsConfirm()']";
            var expectedAlertText = "I am a JS Confirm";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Url = website_url;
            System.Threading.Thread.Sleep(1000);

            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(button_css_selector)));
            System.Threading.Thread.Sleep(1000);
            confirmButton.Click();

            var confirm_win = driver.SwitchTo().Alert();
            confirm_win.Accept();

            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Test Successful");
            }
        }
        [Test, Order(2)]
        public void Dismiss_Test()
        {
            String button_css_selector = "button[onclick='jsConfirm()']";
            var expectedAlertText = "I am a JS Confirm";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            driver.Url = website_url;

            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(button_css_selector)));

            confirmButton.Click();

            var confirm_win = driver.SwitchTo().Alert();
            confirm_win.Dismiss();

            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }
        [Test, Order(3)]
        public void SendalertText_Test()
        {
            String button_css_selector = "button[onclick='jsPrompt()']";
            var expectedAlertText = "I am a JS prompt";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Url = website_url;

            IWebElement confirmButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(button_css_selector)));
            confirmButton.Click();

            var alert_win = driver.SwitchTo().Alert();
            alert_win.SendKeys("This is a test alert message");
            System.Threading.Thread.Sleep(1000);
            alert_win.Accept();

            IWebElement clickResult = driver.FindElement(By.Id("result"));
            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You entered: This is a test alert message")
            {
                Console.WriteLine("Send Text Alert Test Successful");
            }
        }
    }
}