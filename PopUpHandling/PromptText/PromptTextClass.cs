/*
 * project = PopUpHandling
 * Author = Lavanya Gollapudi
 * Created Date = 14/09/2021
 */

using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PopUpHandling.PromptText
{
    public class PromptTextClass
    {
        public PromptTextClass(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsPrompt()']")]
        [CacheLookup]
        public IWebElement promptButton;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
    }
}
