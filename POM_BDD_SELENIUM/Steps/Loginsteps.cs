
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using POM_BDD_SELENIUM.Helper;
using POM_BDD_SELENIUM.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace POM_BDD_SELENIUM.Steps
{
    
    [Binding]
    public class Loginsteps : BaseHelper
    {
        IWebDriver driver;

        public Loginsteps(IWebDriver driver) : base(driver)
        {            
            this.driver = driver;
        }

        LoginpageLocat log = new LoginpageLocat();

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            //driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html");
            Navigate();
        }


        [Given(@"I enterd the valid (.*) and (.*) inti the respectives field")]
        public void GivenIEnterdTheValidAndIntiTheRespectivesField(string username, string password)
        {
            EnterText(By.XPath("//input[@name='UserName']"), username);
            EnterText(By.XPath("//input[@name='Password']"), username);
           
           // log.Login(username, password);
            
        }

        [When(@"i press login button")]
        public void WhenIPressLoginButton()
        {
            Click(By.XPath("//input[@name='Login']"));
            //log.Clicklogin();
        }

        [Then(@"it should return EA pages")]
        public void ThenItShouldReturnEAPages()
        {

        }

    }
}
