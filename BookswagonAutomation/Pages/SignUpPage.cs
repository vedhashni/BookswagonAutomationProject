using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookswagonAutomation.Pages
{
    public class SignUpPage
    {
        //Used to intialize elements of a page class
        public SignUpPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='logo']")]
        [CacheLookup]
        public IWebElement logo;

        [FindsBy(How = How.LinkText, Using = "Signup")]
        [CacheLookup]
        public IWebElement signupbtn;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$txtEmail")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$txtPassword")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$txtConfirmPwd")]
        [CacheLookup]
        public IWebElement confirmpswd;

        [FindsBy(How = How.Name, Using = "ctl00$phBody$SignUp$btnSubmit")]
        [CacheLookup]
        public IWebElement createaccountbtn;
    }
}
