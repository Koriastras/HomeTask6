using System;
using System.Configuration;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;


namespace HomeTask6.Framework
{
    class Settings
    {
        public static IWebDriver GetDriver()
        {

            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(directory);


        }

        public static string GetBrowserType()
        {
            return ConfigurationManager.AppSettings["browserType"];
        }
    }
}

