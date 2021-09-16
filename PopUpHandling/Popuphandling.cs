/*
 * project = PopUpHandling
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace PopUpHandling
{
    public class popuphandling : Base.BaseClass
    {
        
        [Test, Order(1)]
        public void Alert_Test()
        {
            Actions.ActionsDone.AcceptAlert();
        }

        [Test, Order(2)]
        public void Confirm_Test()
        {
            Actions.ActionsDone.ConfirmAlert();
        }

        [Test, Order(3)]
        public void Dismiss_Test()
        {
            Actions.ActionsDone.DismissAlert();
        }

        [Test, Order(4)]
        public void PromptText_Test()
        {
            Actions.ActionsDone.PromptAlertTest();
        }
    }
}