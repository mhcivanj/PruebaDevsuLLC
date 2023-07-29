using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2010.Excel;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOMATION_E2E.UI
{
    public class ViewCarUI
    {
        public static By ButtonCar = By.CssSelector(".shopping_cart_link");
        public static By ButtonCheckOut = By.Id("checkout");

    }
}
