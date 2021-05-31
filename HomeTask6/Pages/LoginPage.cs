using OpenQA.Selenium;


namespace HomeTask6.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement Table => Driver.FindElement(By.XPath("//*[@style = 'width:100%']//child::tr//th"));


        public string GetTable()
        {
            return Table.Text;
        }
     
    }
}
