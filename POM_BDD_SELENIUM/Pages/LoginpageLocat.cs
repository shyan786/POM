using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Text;

namespace POM_BDD_SELENIUM.Pages
{
    public class LoginpageLocat 

    {
        IWebDriver driver;
        //public void initialize()
        //{
        //    driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
        //}
        IWebElement Lnkusername => driver.FindElement(By.Name("UserName"));
        IWebElement Lnkpassword => driver.FindElement(By.Name("Password"));
        IWebElement Butlogin => driver.FindElement(By.Name("Login"));

        
        public void Login(string username ,string password)
        {
            Lnkusername.SendKeys("shyan wasi");
            Lnkpassword.SendKeys("shyan123");
            Butlogin.Click();

        }
        public EAPage Clicklogin()
        {
            Butlogin.Click();
            return new EAPage();
        }

    }
}
