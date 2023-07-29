using OpenQA.Selenium;
using AUTOMATION_E2E.Actions;
using AUTOMATION_E2E.UI;
using static AUTOMATION_E2E.Actions.WaitUtil;
using NUnit.Framework;
using System;

namespace AUTOMATION_E2E.Tasks
{
    public class LoginTask
    {
        public static void LoginSession(IWebDriver driver, string UserName, string Password)
        {
            Enter.Text(driver, LoginUI.UserLogin, UserName);
            Enter.Text(driver, LoginUI.PassLogin, Password);
            Click.On(driver, LoginUI.LoginBotton);
            string Url = driver.Url;
            //Valida si el login es correcto
            Assert.That(Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

    }
}
