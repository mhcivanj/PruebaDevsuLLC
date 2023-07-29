using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;


namespace AUTOMATION_E2E.Actions
{
    public class WaitUtil
    {
        public class WaitUntil
        {
            public static bool ElementIsPresent(IWebDriver driver, By locator)
            {
                try
                {
                    /*MODIFICAR EL VALOR NUMERICO DE LA SIGUIENTE LINEA DE CODIGO PARA QUE
                   QUE EL TIEMPO DE ESPERA ENTRE PASOS SEA MAS RAPIDO O LENTO ***** EL CODIGO
                   ESTA EN SEGUNDOS */
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
                    /////////////////////////////////////////////////////////////////////////
                    wait.Until(drv => drv.FindElement(locator));
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static bool ElementIsPresentStop(IWebDriver driver, By locator)
            {
                try
                {
                    /*MODIFICAR EL VALOR NUMERICO DE LA SIGUIENTE LINEA DE CODIGO PARA QUE
                   QUE EL TIEMPO DE ESPERA ENTRE PASOS SEA MAS RAPIDO O LENTO ***** EL CODIGO
                   ESTA EN SEGUNDOS */
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
                    /////////////////////////////////////////////////////////////////////////
                    wait.Until(drv => drv.FindElement(locator));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }


    }
}
