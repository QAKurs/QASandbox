using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QASandbox.Pages
{
    class EditPersonPage
    {
        readonly IWebDriver driver;

        public By fullName = By.Name("people_name");
        public By submitBtn = By.XPath("//button[@type='submit']");
        public By deleteIcon = By.ClassName("delete-button");
        public By deleteBtn = By.ClassName("btn-danger");

        public EditPersonPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".container.noselect")));
        }
    }
}
