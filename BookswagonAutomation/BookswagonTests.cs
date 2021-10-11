/*summary : Bookswagon Automation with end to end scenario
  Author: Vedhashni V
  Date  : 05-10-21
*/

using Allure.Commons;
using BookswagonAutomation.ActionDo;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace BookswagonAutomation
{
    [TestFixture]
    [AllureNUnit]
    public class BookswagonTests:Base.BaseClass
    {
        public static DoAction pageaction;

        [Test(Description = "signup")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //[Test,Order(0)]
        public void TestMethodForSignUp()
        {
            pageaction = new DoAction();
            pageaction.ToRegisterIntoBookswagon();
        }

        [Test(Description = "login")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //[Test,Order(1)]
        public void TestMethodForLogin()
        {
            pageaction = new DoAction();
            pageaction.LoginIntoBookswagon();
        }
        [Test(Description = "searchproduct")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //[Test,Order(2)]
        public void TestMethodForSearchProduct()
        {
            pageaction = new DoAction();
            pageaction.SearchBook();
        }
        [Test(Description = "addtowishlist")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //[Test,Order(3)]
        public void TestMethodForAddProductToWishList()
        {
            pageaction = new DoAction();
            pageaction.AddBookToWishlist();
        }
        [Test(Description = "Addtocart")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //[Test,Order(4)]
        public void TestMethodToAddToCart()
        {
            pageaction = new DoAction();
            pageaction.AddtoCart();
        }

        [Test(Description = "Toplaceorder")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //[Test]
        public void TestMethodForToPlaceOrder()
        {
            pageaction = new DoAction();
            pageaction.ToPlaceOrder();
        }

        [Test(Description = "Logout")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //[Test]
        public void TestMethodForLogout()
        {
            pageaction = new DoAction();
            pageaction.Logout();
        }

        [Test(Description = "invalidlogin")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //[Test,Order(5)]
        public void TestMethodForInvalidLogin()
        {
            pageaction = new DoAction();
            pageaction.InvalidLogin();
        }
        [Test(Description = "invalidsearch")]
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureIssue("ISSUE-1")]
        [AllureTms("TMS-12")]
        [AllureOwner("User")]
        [AllureSuite("PassedSuite")]
        [AllureSubSuite("NoAssert")]
        //[Test,Order(6)]
        public void TestMethodForInvalidSearch()
        {
            pageaction = new DoAction();
            pageaction.InvalidSearch();
        }
    }
}