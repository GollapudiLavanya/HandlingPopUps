/*
 * project = PopUpHandling
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PopUpHandling.Confirm
{
    public class ConfirmClass
    {
        public ConfirmClass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsConfirm()']")]
        [CacheLookup]
        public IWebElement confirmButton;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
    }
}
