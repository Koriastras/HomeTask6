using HomeTask6.Framework;
using HomeTask6.Framework.Models;
using HomeTask6.Pages;
using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;




namespace HomeTask6.Tests
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        private User firstUser;
        private User secondUser;
        private User thirdUser;
  

        [SetUp]

        protected void Initialize()
        {
            firstUser = User.User1();
          //  secondUser = User.User2();
          //  thirdUser = User.User3();

        }



        [Test]
        public void RegistrationTestForUser1()
        {
            LoginPage loginPage = SiteNavigator.NavigateToLoginPage(Driver).EntryLoginData(firstUser);


            IWebElement elemTable = Driver.FindElement(By.XPath("//*[@style = 'width:100%']//tbody"));
            List<IWebElement> lstTdElem = new List<IWebElement>(elemTable.FindElements(By.TagName("th")));

            string strRowData = "";

             //   string[] TableCotainsUser1 = { User.User1().Username, User.User1().Password, User.User1().FirstName, User.User1().LastName };
            //    if (lstTdElem.Count > 0)
            //    {
            //        foreach (var elemTd in lstTdElem)
            //        {
            //            // "\t\t" for Tab Space
            //            strRowData = strRowData + elemTd.Text + "\t\t";

            //        }
            //    }

            //    foreach (string el in TableCotainsUser1)
            //    {

            //        Assert.That(strRowData.Contains(el));
            //    }
            //}




            // LoginPage loginPage2 = SiteNavigator.NavigateToLoginPage(Driver).EntryLoginData(secondUser);
            //    LoginPage loginPage3 = SiteNavigator.NavigateToLoginPage(Driver).EntryLoginData(thirdUser);

        }
    }
}