﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Smoke.Generales
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pago recording.
    /// </summary>
    [TestModule("ae5c681a-80df-4403-99a1-98550273f9db", ModuleType.Recording, 1)]
    public partial class Pago : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static Pago instance = new Pago();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pago()
        {
            NumPoliza = "04104009714";
            Monto = "";
            NumAutorizacion = "21";
            TipoTarjeta = "American Express";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pago Instance
        {
            get { return instance; }
        }

#region Variables

        string _Monto;

        /// <summary>
        /// Gets or sets the value of variable Monto.
        /// </summary>
        [TestVariable("62455927-bf6a-4b32-bb37-31ae4daa185d")]
        public string Monto
        {
            get { return _Monto; }
            set { _Monto = value; }
        }

        string _NumAutorizacion;

        /// <summary>
        /// Gets or sets the value of variable NumAutorizacion.
        /// </summary>
        [TestVariable("bf8cbdb0-07ce-4740-8e3c-0aee67a4349f")]
        public string NumAutorizacion
        {
            get { return _NumAutorizacion; }
            set { _NumAutorizacion = value; }
        }

        string _TipoTarjeta;

        /// <summary>
        /// Gets or sets the value of variable TipoTarjeta.
        /// </summary>
        [TestVariable("19295a1d-ce3a-4182-8d87-998a25aea032")]
        public string TipoTarjeta
        {
            get { return _TipoTarjeta; }
            set { _TipoTarjeta = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ambiente.
        /// </summary>
        [TestVariable("179cd022-d834-4b47-98d5-e2a34a6a6fce")]
        public string Ambiente
        {
            get { return repo.Ambiente; }
            set { repo.Ambiente = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NumPoliza.
        /// </summary>
        [TestVariable("d6e7c6bc-563c-4ebb-9e35-ebe37fa72d3a")]
        public string NumPoliza
        {
            get { return repo.NumPoliza; }
            set { repo.NumPoliza = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.NuevoPago.Arrow_Select_Poliza' at Center.", repo.SURA.BC.NuevoPago.Arrow_Select_PolizaInfo, new RecordItemIndex(0));
            repo.SURA.BC.NuevoPago.Arrow_Select_Poliza.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.BC.NuevoPago.txtbox_NumeroDePoliza'.", repo.SURA.BC.NuevoPago.txtbox_NumeroDePolizaInfo, new RecordItemIndex(1));
            repo.SURA.BC.NuevoPago.txtbox_NumeroDePoliza.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumPoliza' with focus on 'SURA.BC.NuevoPago.txtbox_NumeroDePoliza'.", repo.SURA.BC.NuevoPago.txtbox_NumeroDePolizaInfo, new RecordItemIndex(2));
            repo.SURA.BC.NuevoPago.txtbox_NumeroDePoliza.PressKeys(NumPoliza);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.NuevoPago.txtbox_NumeroDePoliza' at Center.", repo.SURA.BC.NuevoPago.txtbox_NumeroDePolizaInfo, new RecordItemIndex(3));
            //repo.SURA.BC.NuevoPago.txtbox_NumeroDePoliza.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.NuevoPago.Select_Poliza' at Center.", repo.SURA.BC.NuevoPago.Select_PolizaInfo, new RecordItemIndex(4));
            //repo.SURA.BC.NuevoPago.Select_Poliza.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.txt_PagosMedianteFacturacionDirecta' at Center.", repo.SURA.BC.txt_PagosMedianteFacturacionDirectaInfo, new RecordItemIndex(5));
            repo.SURA.BC.txt_PagosMedianteFacturacionDirecta.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to not exist. Associated repository item: 'SURA.BC.NuevoPago.Copy_of_txtbox_Monto'", repo.SURA.BC.NuevoPago.Copy_of_txtbox_MontoInfo, new ActionTimeout(40000), new RecordItemIndex(6));
            repo.SURA.BC.NuevoPago.Copy_of_txtbox_MontoInfo.WaitForNotExists(40000);
            
            try {
                Report.Log(ReportLevel.Info, "Get Value", "(Optional Action)\r\nGetting attribute 'InnerText' from item 'SURA_ContinueOnFail.montoPagar' and assigning the part of its value captured by '[0-9.,]+' to variable 'Monto'.", repo.SURA_ContinueOnFail.montoPagarInfo, new RecordItemIndex(7));
                Monto = repo.SURA_ContinueOnFail.montoPagar.Element.GetAttributeValueText("InnerText", new Regex("[0-9.,]+"));
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            Report.Log(ReportLevel.Info, "User", "El monto a pagar es:", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "User", Monto, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.BC.NuevoPago.txtbox_Monto'.", repo.SURA.BC.NuevoPago.txtbox_MontoInfo, new RecordItemIndex(10));
            repo.SURA.BC.NuevoPago.txtbox_Monto.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Monto' with focus on 'SURA.BC.NuevoPago.txtbox_Monto'.", repo.SURA.BC.NuevoPago.txtbox_MontoInfo, new RecordItemIndex(11));
            repo.SURA.BC.NuevoPago.txtbox_Monto.PressKeys(Monto);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.txt_PagosMedianteFacturacionDirecta' at Center.", repo.SURA.BC.txt_PagosMedianteFacturacionDirectaInfo, new RecordItemIndex(12));
            repo.SURA.BC.txt_PagosMedianteFacturacionDirecta.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to not exist. Associated repository item: 'SURA.BC.NuevoPago.Copy_of_txtbox_Monto'", repo.SURA.BC.NuevoPago.Copy_of_txtbox_MontoInfo, new ActionTimeout(40000), new RecordItemIndex(13));
            repo.SURA.BC.NuevoPago.Copy_of_txtbox_MontoInfo.WaitForNotExists(40000);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(14));
            //Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to not exist. Associated repository item: 'SURA.BC.NuevoPago.Copy_of_txtbox_NumAutorizacion'", repo.SURA.BC.NuevoPago.Copy_of_txtbox_NumAutorizacionInfo, new ActionTimeout(40000), new RecordItemIndex(15));
            repo.SURA.BC.NuevoPago.Copy_of_txtbox_NumAutorizacionInfo.WaitForNotExists(40000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.NuevoPago.txtbox_NumAutorizacion' at Center.", repo.SURA.BC.NuevoPago.txtbox_NumAutorizacionInfo, new RecordItemIndex(16));
            repo.SURA.BC.NuevoPago.txtbox_NumAutorizacion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumAutorizacion' with focus on 'SURA.BC.NuevoPago.txtbox_NumAutorizacion'.", repo.SURA.BC.NuevoPago.txtbox_NumAutorizacionInfo, new RecordItemIndex(17));
            repo.SURA.BC.NuevoPago.txtbox_NumAutorizacion.PressKeys(NumAutorizacion);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.NuevoPago.DetallesDePago' at Center.", repo.SURA.BC.NuevoPago.DetallesDePagoInfo, new RecordItemIndex(18));
            repo.SURA.BC.NuevoPago.DetallesDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.BC.NuevoPago.Copy_of_txtbox_TipoTarjeta'", repo.SURA.BC.NuevoPago.Copy_of_txtbox_TipoTarjetaInfo, new ActionTimeout(30000), new RecordItemIndex(19));
            repo.SURA.BC.NuevoPago.Copy_of_txtbox_TipoTarjetaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.BC.NuevoPago.txtbox_TipoTarjeta'.", repo.SURA.BC.NuevoPago.txtbox_TipoTarjetaInfo, new RecordItemIndex(20));
            Keyboard.PrepareFocus(repo.SURA.BC.NuevoPago.txtbox_TipoTarjeta);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoTarjeta' with focus on 'SURA.BC.NuevoPago.txtbox_TipoTarjeta'.", repo.SURA.BC.NuevoPago.txtbox_TipoTarjetaInfo, new RecordItemIndex(21));
            repo.SURA.BC.NuevoPago.txtbox_TipoTarjeta.PressKeys(TipoTarjeta);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.txt_PagosMedianteFacturacionDirecta' at Center.", repo.SURA.BC.txt_PagosMedianteFacturacionDirectaInfo, new RecordItemIndex(22));
            repo.SURA.BC.txt_PagosMedianteFacturacionDirecta.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(23));
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SURA_ContinueOnFail.bttn_Ejecutar' at Center.", repo.SURA_ContinueOnFail.bttn_EjecutarInfo, new RecordItemIndex(24));
                repo.SURA_ContinueOnFail.bttn_Ejecutar.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(24)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'SURA.Imag_torta_pago'", repo.SURA.Imag_torta_pagoInfo, new ActionTimeout(60000), new RecordItemIndex(25));
            repo.SURA.Imag_torta_pagoInfo.WaitForExists(60000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
