/*
 * project = PopUpHandling
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PopUpHandling.Alert
{
    public class AlertClass
    {
        public AlertClass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsAlert()']")]
        [CacheLookup]
        public IWebElement alertButton;
        
        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
    }
}
       