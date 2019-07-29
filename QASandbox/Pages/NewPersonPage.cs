using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QASandbox.Pages
{
    class NewPersonPage
    {
        readonly IWebDriver driver;

        public By fullName = By.Name("people_name");
        public By technology = By.CssSelector(".pb-3 [fill='currentColor']");
        public By seniority = By.CssSelector(".pb-3 [placeholder='Select seniority']");
        public By specTech = By.CssSelector(".pb-3 [aria-label='Java']");
        public By specSen = By.CssSelector(".pb-3 [aria-label='Medior']");
        public By submitBtn = By.XPath("//button[@type='submit']");
        public By techName = By.Name("technology_title");
        public By seniorityName = By.Name("seniority_title");

        public NewPersonPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("create-profile")));
        }
    }
}
