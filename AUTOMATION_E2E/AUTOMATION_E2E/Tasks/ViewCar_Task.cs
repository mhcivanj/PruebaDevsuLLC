using AUTOMATION_E2E.Actions;
using OpenQA.Selenium;
using AUTOMATION_E2E.UI;
using NUnit.Framework;
using static AUTOMATION_E2E.Actions.WaitUtil;

namespace AUTOMATION_E2E.Tasks
{
    public class ViewCar_Task
    {

        public static void ViewCar(IWebDriver driver)
        {
            Click.On(driver, ViewCarUI.ButtonCar);
            var elements = driver.FindElements(ViewCarUI.ButtonCheckOut);
            Assert.True(elements.Count > 0);

            //ESPERA 3 SEGUNDOS ANTES DE SIGUIENTE PASO
            WaitUntil.ElementIsPresentStop(driver, ViewCarUI.ButtonCar);

        }
    }
}
