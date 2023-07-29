using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOMATION_E2E.Tests
{
    public class Base_Test
    {
        public IWebDriver driver;
        public string Url = "https://www.saucedemo.com/";

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(); ;
            driver.Navigate().GoToUrl(Url);
            driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);

        }
        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }
    }
}
