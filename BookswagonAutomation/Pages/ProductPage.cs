using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookswagonAutomation.Pages
{
    public class ProductPage
    {
        //Used to intialize elements of a page class
        public ProductPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "btn-black")]
        [CacheLookup]
        public IWebElement addtowishlistbtn;

        [FindsBy(How = How.Id, Using = "ctl00_phBody_lblheading")]
        [CacheLookup]
        public IWebElement mywislist;

        [FindsBy(How = How.XPath, Using = "//tbody/tr[3]/td[1]/div[1]/a[1]/input[1]")]
        [CacheLookup]
        public IWebElement BuyNow;
    }
}
