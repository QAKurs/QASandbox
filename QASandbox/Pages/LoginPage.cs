using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QASandbox.Pages
{
    class LoginPage
    {
        readonly IWebDriver driver;

        public By email = By.Name("email");
        public By password = By.Name("password");
        public By submit = By.XPath("//button[@type='submit']");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("login")));
        }
    }
}
