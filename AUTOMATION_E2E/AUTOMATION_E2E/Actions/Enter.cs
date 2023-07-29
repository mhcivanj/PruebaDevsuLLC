using OpenQA.Selenium;


namespace AUTOMATION_E2E.Actions
{
    public class Enter
    {
        public static void Text(IWebDriver driver, By locator, string text)
        {
            driver.FindElement(locator).SendKeys(text);

        }
    }
}
