using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QASandbox.Helpers
{
    public class Utilities
    {
        readonly IWebDriver driver;
        private static readonly Random RandomName = new Random();

        public Utilities(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnElement(By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(selector)).Click();
        }

        public void ClearTextFromElement(By selector)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).Clear();
        }

        public void EnterTextInElement(By selector, string text)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector)).SendKeys(text);
        }

        public IWebElement TextPresentInElement(string text)
        {
            By textElement = By.XPath("//*[contains(text(),'" + text + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(textElement));
        }

        public string ReturnTextFromElement(By selector)
        {
            return driver.FindElement(selector).GetAttribute("textContent");
        }

        public string ReverseWords(string fullName)
        {
            string[] words = fullName.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public string GenerateRandomName()
        {
            const string capitalChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return
              new string(Enumerable.Repeat(capitalChar, 6)
              .Select(s => s[RandomName.Next(6)]).ToArray());
        }
    }
}
