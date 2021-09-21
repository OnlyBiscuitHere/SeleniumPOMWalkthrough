using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough.lib.pages
{
    public class AP_UserPage
    {
        private IWebDriver _seleniumDriver;
        private string _UserPageUrl = AppConfigReader.UserPageURL;
        private IWebElement _shoppingCartButton => _seleniumDriver.FindElement(By.Id("shopping_cart_container"));
        private IWebElement _header => _seleniumDriver.FindElement(By.Id("header_container"));
        public AP_UserPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }
        public void GoToUserPage() => _seleniumDriver.Navigate().GoToUrl(_UserPageUrl);
        public void ClickShoppingButton() => _shoppingCartButton.Click();
        public string GetHeaderText() => _header.Text;
    }
}
