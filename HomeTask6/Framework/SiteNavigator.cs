using System.Configuration;
using HomeTask6.Pages;
using OpenQA.Selenium;

namespace HomeTask6.Framework
{
    public class SiteNavigator
    {
        public static RegistrationPage NavigateToLoginPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["baseUrl"]);
            return new RegistrationPage(driver);

        }
    }
}