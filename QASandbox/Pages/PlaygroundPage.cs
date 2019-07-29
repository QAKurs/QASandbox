using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QASandbox.Pages
{
    class PlaygroundPage
    {
        readonly IWebDriver driver;

        public By peopleTab = By.Id("test2");
        public By techTab = By.Id("test4");
        public By senTab = By.Id("test3");
        public By person = By.ClassName("list-group-item");
        public By defaultMsg = By.ClassName("muted-text");

        public PlaygroundPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("wrapper")));
        }
    }
}
