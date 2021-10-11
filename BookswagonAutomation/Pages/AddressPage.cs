using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace BookswagonAutomation.Pages
{
    public class AddressPage
    {
        //Used to intialize elements of a page class
        public AddressPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Continue')]")]
        [CacheLookup]
        public IWebElement continuebtn;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewRecipientName")]
        [CacheLookup]
        public IWebElement name;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewCompanyName")]
        [CacheLookup]
        public IWebElement companyname;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewAddress")]
        [CacheLookup]
        public IWebElement address;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewLandmark")]
        [CacheLookup]
        public IWebElement landmark;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCountry")]
        [CacheLookup]
        public IWebElement country;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewState")]
        [CacheLookup]
        public IWebElement state;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$ddlNewCities")]
        [CacheLookup]
        public IWebElement city;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewPincode")]
        [CacheLookup]
        public IWebElement pincode;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewMobile")]
        [CacheLookup]
        public IWebElement mobile;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$txtNewPhone")]
        [CacheLookup]
        public IWebElement phone;

        [FindsBy(How = How.Name, Using = "ctl00$cpBody$imgSaveNew")]
        [CacheLookup]
        public IWebElement saveandcontinuebtn;

        [FindsBy(How = How.XPath, Using = "//body[1]/form[1]/div[3]/div[3]/div[2]/div[1]/div[2]/div[2]/div[2]/div[4]/div[2]/input[1]")]
        [CacheLookup]
        public IWebElement savebtn;
    }
}
