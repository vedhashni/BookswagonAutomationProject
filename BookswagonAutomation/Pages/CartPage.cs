using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookswagonAutomation.Pages
{
    public class CartPage
    {
        //Used to intialize elements of a page class
        public CartPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "BookCart$lvCart$imgPayment")]
        [CacheLookup]
        public IWebElement placeorderbtn;

        [FindsBy(How = How.Name, Using = "BookCart$lvCart$ctrl0$txtQty")]
        [CacheLookup]
        public IWebElement quantity;

        [FindsBy(How = How.Id, Using = "BookCart_lvCart_ctrl0_rfvQty")]
        [CacheLookup]
        public IWebElement requiredalertmsg;


        [FindsBy(How = How.Name, Using = "BookCart$lvCart$ctrl0$imgUpdate")]
        [CacheLookup]
        public IWebElement updatequantityicon;

        [FindsBy(How = How.Name, Using = "BookCart$lvCart$ctrl0$imgUpdate")]
        [CacheLookup]
        public IWebElement updatedsuccessfullymsg;
    }
}
