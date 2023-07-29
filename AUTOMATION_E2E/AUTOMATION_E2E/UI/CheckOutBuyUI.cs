using OpenQA.Selenium;


namespace AUTOMATION_E2E.UI
{
    public class CheckOutBuyUI
    {
        public static By BottonCheckOut = By.Id("checkout");
        public static By FirsName = By.Id("first-name");
        public static By LastName = By.Id("last-name");
        public static By PostalCode = By.Id("postal-code");
        public static By BottonContinue = By.Id("continue");
        public static By LabelSummary = By.CssSelector(".summary_total_label");
        public static By BottonFinish = By.Id("finish");
        public static By LabelComplete = (By.CssSelector(".title"));
        public static By LabelThank = By.XPath("//div[@id=\'checkout_complete_container\']/h2");


    }
}   
