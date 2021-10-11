using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookswagonAutomation.Pages
{
   public class SearchPage
    {
        //Used to intialize elements of a page class
        public SearchPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        [CacheLookup]
        public IWebElement searchbar;

        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_Button1")]
        [CacheLookup]
        public IWebElement searchicon;

        [FindsBy(How = How.XPath, Using = "//img[@class='bklazy']")]
        [CacheLookup]
        public IWebElement particularproduct;

        [FindsBy(How = How.ClassName, Using = "not-match")]
        [CacheLookup]
        public IWebElement notfoundmessage;
    }
}
