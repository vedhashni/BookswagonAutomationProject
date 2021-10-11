using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookswagonAutomation.Pages
{
    public class LogoutPage
    {
        //Used to intialize elements of a page class
        public LogoutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Choose your mode of payment')]")]
        [CacheLookup]
        public IWebElement paymentmsg;

        [FindsBy(How = How.LinkText, Using = "Logout")]
        [CacheLookup]
        public IWebElement logoutbtn;
    }
}
