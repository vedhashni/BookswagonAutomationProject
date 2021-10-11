using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookswagonAutomation.Pages
{
    public class LoginPage
    {
        //Used to intialize elements of a page class
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='logo']")]
        [CacheLookup]
        public IWebElement logo;

        [FindsBy(How = How.LinkText, Using = "Login")]
        [CacheLookup]
        public IWebElement login;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtEmail")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$txtPassword")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignIn$btnLogin")]
        [CacheLookup]
        public IWebElement loginbtn;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_SignIn_lblmsg")]
        [CacheLookup]
        public IWebElement errormessage;
    }
}
