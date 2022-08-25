using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace POM_BDD_SELENIUM.Helper
{
    [Binding]
    public sealed class Hooks
    {
        IObjectContainer _objectContainer;
        IWebDriver driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
