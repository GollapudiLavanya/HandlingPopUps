/*
 * project = PopUpHandling
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using PopUpHandling.Alert;
using PopUpHandling.Confirm;
using PopUpHandling.Dismiss;
using PopUpHandling.PromptText;
using System;

namespace PopUpHandling.Actions
{
    public class ActionsDone : Base.BaseClass
    {
        
        public static void AcceptAlert()
        {
            //find the button element by using Css Selector
            AlertClass alert = new AlertClass(driver);
            alert.alertButton.Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var alert_win = driver.SwitchTo().Alert();
            //Accept the alert
            alert_win.Accept();

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(alert.clickResult.Text);
            System.Threading.Thread.Sleep(2000);
            if (alert.clickResult.Text == "You successfuly clicked an alert")
            {
                Console.WriteLine("Alert Test Successful");
            }
            
        }

        public static void ConfirmAlert()
        {
            ConfirmClass confirm = new ConfirmClass(driver);
            confirm.confirmButton.Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var confirm_win = driver.SwitchTo().Alert();
            //Accept the alert
            confirm_win.Accept();
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(confirm.clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (confirm.clickResult.Text == "You clicked: Ok")
            {
                Console.WriteLine("Confirm Test Successful");
            }
        }

        public static void DismissAlert()
        {
            DismissClass dismiss = new DismissClass(driver);
            dismiss.dismissButton.Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var confirm_win = driver.SwitchTo().Alert();
            //Dismiss the alert
            confirm_win.Dismiss();
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(dismiss.clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (dismiss.clickResult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }
        public static void PromptAlertTest()
        {
            PromptTextClass prompt = new PromptTextClass(driver);
            prompt.promptButton.Click();
            System.Threading.Thread.Sleep(2000);

            //send the commands to alert window
            var alert_win = driver.SwitchTo().Alert();
            alert_win.SendKeys("This is a test alert message");
            //Accept the alert
            alert_win.Accept();
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(prompt.clickResult.Text);
            System.Threading.Thread.Sleep(2000);

            if (prompt.clickResult.Text == "You entered: This is a test alert message")
            {
                Console.WriteLine("Send Text Alert Test Successful");
            }
            
        }
    }
}

