using OpenQA.Selenium;


namespace AUTOMATION_E2E.Actions
{
     public class Click
    {
        public static void On(IWebDriver driver, By locator)
        {
          driver.FindElement(locator).Click();
        }       
    }
}
