using AUTOMATION_E2E.Actions;
using AUTOMATION_E2E.UI;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AUTOMATION_E2E.Actions.WaitUtil;

namespace AUTOMATION_E2E.Tasks
{
    public class CheckOutBuy_Task
    {
        
        public static void CheckOutBuy(IWebDriver driver, string name, string apellido, string codigo)
        {
            string LabelThankText = "Thank you for your order!";
            string LabelCompleteText = "Checkout: Complete!";
            //cargar formulario
            Click.On(driver, CheckOutBuyUI.BottonCheckOut);
            Enter.Text(driver, CheckOutBuyUI.FirsName, name);
            Enter.Text(driver, CheckOutBuyUI.LastName, apellido);
            Enter.Text(driver, CheckOutBuyUI.PostalCode, codigo);

            //ESPERA 3 SEGUNDOS ANTES DE SIGUIENTE PASO
            WaitUntil.ElementIsPresentStop(driver, CheckOutBuyUI.BottonContinue);

            var elementBtnContinue = driver.FindElements(CheckOutBuyUI.BottonContinue);
            Assert.True(elementBtnContinue.Count > 0);
            Click.On(driver, CheckOutBuyUI.BottonContinue);
            var elementsSummary = driver.FindElements(CheckOutBuyUI.LabelSummary);
            Assert.True(elementsSummary.Count > 0);

            //ESPERA 3 SEGUNDOS ANTES DE SIGUIENTE PASO
            WaitUntil.ElementIsPresentStop(driver, CheckOutBuyUI.BottonFinish);

            Click.On(driver, CheckOutBuyUI.BottonFinish);
            Assert.That(driver.FindElement(CheckOutBuyUI.LabelComplete).Text, Is.EqualTo(LabelCompleteText));
            driver.FindElement(By.Id("checkout_complete_container")).Click();
            Assert.That(driver.FindElement(CheckOutBuyUI.LabelThank).Text, Is.EqualTo(LabelThankText));
            
            //ESPERA 3 SEGUNDOS ANTES DE SIGUIENTE PASO
            WaitUntil.ElementIsPresentStop(driver, CheckOutBuyUI.LabelThank);
        }
    }
}
