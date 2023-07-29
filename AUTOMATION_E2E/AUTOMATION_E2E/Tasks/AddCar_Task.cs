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
    public class AddCar_Task
    {
        public static void AddCar(IWebDriver driver)
        {
            //Agregar dos productos al carrito
            var elements1 = driver.FindElements(AddProductCarUI.Product_1);
            //Assert valida si el elemento existe
            Assert.True(elements1.Count > 0);
            Click.On(driver, AddProductCarUI.Product_1);

            var element2 = driver.FindElements(AddProductCarUI.Product_2);
            //Assert valida si el elemento existe
            Assert.True(element2.Count > 0);
            Click.On(driver, AddProductCarUI.Product_2);

            //ESPERA 3 SEGUNDOS ANTES DE SIGUIENTE PASO
            WaitUntil.ElementIsPresentStop(driver, AddProductCarUI.Product_2);

        }
    }
}
