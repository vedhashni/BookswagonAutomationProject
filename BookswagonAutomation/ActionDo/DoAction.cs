using BookswagonAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookswagonAutomation.ActionDo
{
    public class DoAction:Base.BaseClass
    {
        public static SignUpPage sign;
        public static ExcelOperation excel;
        public static LoginPage loginaction;
        public static SearchPage search;
        public static ProductPage product;
        public static CartPage cart;
        public static AddressPage page;
        public static LogoutPage logout;

        public void ToRegisterIntoBookswagon()
        {
            sign = new SignUpPage(driver);
            excel = new ExcelOperation();
            try
            {
                if (sign.logo.Displayed)
                {
                    sign.signupbtn.Click();
                    Assert.AreEqual("https://www.bookswagon.com/signup", driver.Url);
                    excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\BookswagonAutomation\BookswagonAutomation\DataForTesting\ExcelDataForBookswagon.xlsx");
                    sign.email.SendKeys(excel.ReadData(1, "Email"));
                    sign.password.SendKeys(excel.ReadData(1, "Password"));
                    sign.confirmpswd.SendKeys(excel.ReadData(1, "ConfirmPassword"));
                    sign.createaccountbtn.Click();
                    TakeScreenShot();
                    System.Threading.Thread.Sleep(2000);
                }
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "webdriver unable to locate the element");
            }
        }

        public void LoginIntoBookswagon()
        {
            loginaction = new LoginPage(driver);
            excel = new ExcelOperation();
            try
            {
                if (loginaction.logo.Displayed)
                {
                    loginaction.login.Click();
                    Assert.AreEqual("https://www.bookswagon.com/login", driver.Url);
                    excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\BookswagonAutomation\BookswagonAutomation\DataForTesting\ExcelDataForBookswagon.xlsx");
                    loginaction.email.SendKeys(excel.ReadData(1, "Email"));
                    loginaction.password.SendKeys(excel.ReadData(1, "Password"));
                    if (loginaction.email != null && loginaction.password != null)
                    {
                        loginaction.loginbtn.Click();
                        TakeScreenShot();
                        string title1 = "Online BookStore India, Buy Books Online, Buy Book Online India - Bookswagon.com";
                        string title = driver.Title;
                        Assert.AreEqual(title1, title);
                        log.Info("Logged In Successfully");
                    }
                }
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "webdriver unable to locate the element");
            }
        }

        public void SearchBook()
        {
            search = new SearchPage(driver);
            excel = new ExcelOperation();
            try
            {
                LoginIntoBookswagon();
                search.searchbar.Click();
                excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\BookswagonAutomation\BookswagonAutomation\DataForTesting\ExcelDataForSearch.xlsx");
                search.searchbar.SendKeys(excel.ReadData(1, "SearchProduct"));
                if (search.searchbar != null)
                {
                    search.searchbar.SendKeys(Keys.ArrowUp);
                    search.searchbar.SendKeys(Keys.ArrowDown);
                    search.searchbar.SendKeys(Keys.Enter);
                    search.searchicon.Click();
                    TakeScreenShot();
                    System.Threading.Thread.Sleep(500);
                    log.Info("Product successfully searched");
                }
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "webdriver unable to loacte the element");
            }
        }

        public void AddBookToWishlist()
        {
            search = new SearchPage(driver);
            product = new ProductPage(driver);
            try
            {
                SearchBook();
                search.particularproduct.Click();
                product.addtowishlistbtn.Click();
                if (product.mywislist.Displayed)
                {
                    log.Info("product added to wislist");
                    product.BuyNow.Click();
                    TakeScreenShot();
                }
                System.Threading.Thread.Sleep(500);
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "webdriver unable to locate the element");
            }

        }

        public void AddtoCart()
        {
            cart = new CartPage(driver);
            
                AddBookToWishlist();
                driver.SwitchTo().Frame(0);
                cart.quantity.Click();
                cart.quantity.SendKeys(Keys.Delete);
                cart.quantity.SendKeys("2");
                cart.updatequantityicon.Click();
                Assert.True(cart.updatedsuccessfullymsg.Displayed);
                System.Threading.Thread.Sleep(1000);
                cart.placeorderbtn.Click();
                System.Threading.Thread.Sleep(1000);    
        }

        public void ToPlaceOrder()
        {
            page = new AddressPage(driver);
            excel = new ExcelOperation();
            try
            {
                AddtoCart();
                string url1 = "https://www.bookswagon.com/checkout-login";
                string url2 = driver.Url;
                Assert.AreEqual(url1, url2);
                page.continuebtn.Click();
                System.Threading.Thread.Sleep(500);
                string url3 = "https://www.bookswagon.com/shippingoption.aspx";
                string url4 = driver.Url;
                Assert.AreEqual(url3, url4);
                excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\BookswagonAutomation\BookswagonAutomation\DataForTesting\ExcelDataForAddress.xlsx");
                page.name.SendKeys(excel.ReadData(1, "Recipient Name"));
                page.companyname.SendKeys(excel.ReadData(1, "Company Name"));
                page.address.SendKeys(excel.ReadData(1, "Street Address"));
                page.landmark.SendKeys(excel.ReadData(1, "Landmark"));
                SelectElement element1 = new SelectElement(page.country);
                element1.SelectByValue("India");
                System.Threading.Thread.Sleep(500);
                SelectElement element2 = new SelectElement(page.state);
                element2.SelectByText("Tamil Nadu");
                System.Threading.Thread.Sleep(500);
                SelectElement element3 = new SelectElement(page.city);
                element3.SelectByText("Chennai");
                System.Threading.Thread.Sleep(500);
                page.pincode.SendKeys(excel.ReadData(1, "PIN"));
                page.mobile.SendKeys(excel.ReadData(1, "Mobile"));
                page.phone.SendKeys(excel.ReadData(1, "Phone"));
                page.saveandcontinuebtn.Click();
                System.Threading.Thread.Sleep(500);
                string url5 = "https://www.bookswagon.com/viewshoppingcart.aspx";
                string url6 = driver.Url;
                Assert.AreEqual(url5, url6);
                page.savebtn.Click();
                System.Threading.Thread.Sleep(500);
            }

            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "webdriver unable to locate the element");
            }
        }

        public void Logout()
        {
            logout = new LogoutPage(driver);
            try
            {
                ToPlaceOrder();
                Assert.True(logout.paymentmsg.Displayed);
                logout.logoutbtn.Click();
                Assert.AreEqual("https://www.bookswagon.com/login", driver.Url);
                System.Threading.Thread.Sleep(2000);
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "webdriver unable to locate the element");
            }
        }

        public void InvalidLogin()
        {
            loginaction = new LoginPage(driver);
            excel = new ExcelOperation();
            try
            {
                if (loginaction.logo.Displayed)
                {
                    loginaction.login.Click();
                    excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\BookswagonAutomation\BookswagonAutomation\DataForTesting\ExcelDataForBookswagon.xlsx");
                    loginaction.email.SendKeys(excel.ReadData(2, "Email"));
                    loginaction.password.SendKeys(excel.ReadData(2, "Password"));
                    if (loginaction.email != null && loginaction.password != null)
                    {
                        loginaction.loginbtn.Click();
                        TakeScreenShot();
                        Assert.True(loginaction.errormessage.Displayed);
                    }
                }
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "webdriver unable to locate the element");
            }

        }

        public void InvalidSearch()
        {
            search = new SearchPage(driver);
            excel = new ExcelOperation();
            try
            {
                LoginIntoBookswagon();
                search.searchbar.Click();
                excel.PopulateFromExcel(@"C:\Users\vedhashni.v\source\repos\BookswagonAutomation\BookswagonAutomation\DataForTesting\ExcelDataForSearch.xlsx");
                search.searchbar.SendKeys(excel.ReadData(2, "SearchProduct"));
                if (search.searchbar != null)
                {
                    search.searchicon.Click();
                    Assert.True(search.notfoundmessage.Displayed);
                    TakeScreenShot();
                    
                }
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.NoSuchElementException, "webdriver unable to loacte the element");
            }
        }
    }
}
