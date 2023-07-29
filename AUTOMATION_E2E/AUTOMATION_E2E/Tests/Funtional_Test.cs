using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using AUTOMATION_E2E.Actions;
using static AUTOMATION_E2E.Actions.WaitUtil;
using OpenQA.Selenium.Support.UI;
using AUTOMATION_E2E.Tasks;
using System;
using AUTOMATION.Tasks;

namespace AUTOMATION_E2E.Tests
{

    public class Funtional_Test
    {
        [TestFixture]
        public class Test : Base_Test
        {

                   
            [Test, Order(1)]
            public void TestProducCar()
            {
                           
                //Login
                string basePath = Environment.CurrentDirectory;
                basePath = basePath.Replace("\\bin\\Debug", "\\Files\\UserPass.xlsx");
                var(User, Pass) = Load_User.FilesXLSX(basePath);

                LoginTask.LoginSession(driver, User, Pass);

                //Agrgar Producto al carrito
                AddCar_Task.AddCar(driver);


                //Ver carrito de compras
                ViewCar_Task.ViewCar(driver);


                //Finalizar compra
                //Metodo que carga los datos de Excel
                string basePathData = Environment.CurrentDirectory;
                basePathData = basePathData.Replace("\\bin\\Debug", "\\Files\\DataUser.xlsx");
                object[] values = LoadExcel.LoadFileExcel(basePathData);

                //Metodo que carga los datos de Excel al formulario del sitio Web
                CheckOutBuy_Task.CheckOutBuy(driver,
                                  values[0].ToString(),
                                  values[1].ToString(),
                                  values[2].ToString());



            }



        }
                     

    }
}
