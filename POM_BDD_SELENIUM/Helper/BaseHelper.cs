using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace POM_BDD_SELENIUM.Helper
{
    public class BaseHelper
    {
        IWebDriver driver;

        public BaseHelper(IWebDriver driver)
        {
            this.driver = driver;
        }
       
        public void EnterText(By el, string value)
        {
            driver.FindElement(el).SendKeys(value);
        }

        public void Click(By el)
        {
            driver.FindElement(el).Click();
        }
        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
        }
    }
}
