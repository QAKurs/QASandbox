using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QASandbox.Pages
{
    class Homepage
    {
        readonly IWebDriver driver;

        public By loginBtn = By.CssSelector(".nav-link[href='/login']");

        public Homepage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("landing")));
        }
    }
}
