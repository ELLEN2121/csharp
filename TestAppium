using System;
using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace MSTestOverview
{
    [TestClass]
    public class Test
    {

        [TestMethod]
        public void verificar() {


            WindowsDriver<WindowsElement> sessionCalc;
            AppiumOptions appOptions = new AppiumOptions();
            appOptions.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            sessionCalc = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);
            /*
                        #region Declaração de variaveis
                         var btnUm = sessionCalc.FindElementByName("Um");
                         var btnDois = sessionCalc.FindElementByName("Dois");
                         var btnTres = sessionCalc.FindElementByName("Três");
                         var btnQuatro = sessionCalc.FindElementByName("Quatro");
                         var btnCinco = sessionCalc.FindElementByName("Cinco");
                         var btnSeis = sessionCalc.FindElementByName("Seis");
                         var btnSete = sessionCalc.FindElementByName("Sete");
                         var btnOito = sessionCalc.FindElementByName("Oito");
                         var btnNove = sessionCalc.FindElementByName("Nove");
                         var btnSoma = sessionCalc.FindElementByName("Mais");
                         var btnDivisao = sessionCalc.FindElementByName("Dividir por");
                         var btnDiminuicao = sessionCalc.FindElementByName("Menos");
                         var btnMultiplica = sessionCalc.FindElementByName("Multiplicar por");
                         var btnPorCento = sessionCalc.FindElementByName("Por Cento");
                         var btnUmpor = sessionCalc.FindElementByName("Recíproco");
                         var btnLimparTela = sessionCalc.FindElementByName("Limpar entrada");
                         var btnIgual = sessionCalc.FindElementByName("Igual a");
                         btnSete.Click();
                         btnSoma.Click();
                         btnCinco.Click();

                         var btnLog = sessionCalc.FindElementByName("Log");
                         var abrirNavegacao = sessionCalc.FindElementByName("Abrir Navegação");
                         var cientificaCalculadora = sessionCalc.FindElementByName("Científica Calculadora");
                         var btnTrigonometria = sessionCalc.FindElementByName("Trigonometria");
                         var btnCosseno = sessionCalc.FindElementByName("Cosseno");
                         var btnSin = sessionCalc.FindElementByName("Seno");
                         var txtInsere = sessionCalc.FindElementByName("A exibição é 0");
                         #endregion



                         #region Abrir Calculadora  Cientifica
                         #endregion
                        */


             var btnSoma = sessionCalc.FindElementByName("Mais");
             var btnUmpor = sessionCalc.FindElementByName("Recíproco");
             var txtInsere = sessionCalc.FindElementByName("A exibição é 0");
             var btnlimparTela = sessionCalc.FindElementByName("Limpar entrada");
             var btnIgual = sessionCalc.FindElementByName("Igual a");


             #region Fração
             txtInsere.SendKeys("255");
             btnUmpor.Click();
             Thread.Sleep(2000);
             btnlimparTela.Click();
             #endregion

             #region Soma
             txtInsere.SendKeys("127");
             btnSoma.Click();
             Thread.Sleep(2000);
             txtInsere.SendKeys("341");
             btnIgual.Click();
             Thread.Sleep(2000);
             btnlimparTela.Click();
             #endregion
            

            var btnMultiplica = sessionCalc.FindElementByName("Multiplicar por");
            var btnPorCento = sessionCalc.FindElementByName("Por Cento");

            #region Multiplicação
             txtInsere.SendKeys("321");
             btnMultiplica.Click();
             txtInsere.SendKeys("888");
             btnIgual.Click();
             Thread.Sleep(2000);
             btnlimparTela.Click();
             #endregion

             #region Por Cento
             txtInsere.SendKeys("321");
             btnPorCento.Click();
             btnIgual.Click();
             Thread.Sleep(2000);
             btnlimparTela.Click();
             #endregion
        }
    }
}
