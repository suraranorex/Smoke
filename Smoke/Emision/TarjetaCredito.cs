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

namespace Smoke.Emision
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TarjetaCredito recording.
    /// </summary>
    [TestModule("ade5c198-8c25-496b-ba39-d3c540508e1f", ModuleType.Recording, 1)]
    public partial class TarjetaCredito : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static TarjetaCredito instance = new TarjetaCredito();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TarjetaCredito()
        {
            TipoTarjeta = "Diners";
            NumTarjetaCred = "36093515680612";
            FechaVencimiento = "05/2024";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TarjetaCredito Instance
        {
            get { return instance; }
        }

#region Variables

        string _TipoTarjeta;

        /// <summary>
        /// Gets or sets the value of variable TipoTarjeta.
        /// </summary>
        [TestVariable("7156f13f-2933-4961-ab87-cea7c8368f4c")]
        public string TipoTarjeta
        {
            get { return _TipoTarjeta; }
            set { _TipoTarjeta = value; }
        }

        string _NumTarjetaCred;

        /// <summary>
        /// Gets or sets the value of variable NumTarjetaCred.
        /// </summary>
        [TestVariable("c16340a4-faf7-4593-ae3e-515b0b5e5330")]
        public string NumTarjetaCred
        {
            get { return _NumTarjetaCred; }
            set { _NumTarjetaCred = value; }
        }

        string _FechaVencimiento;

        /// <summary>
        /// Gets or sets the value of variable FechaVencimiento.
        /// </summary>
        [TestVariable("6acd7d87-b7f4-4637-9693-095e158ed63c")]
        public string FechaVencimiento
        {
            get { return _FechaVencimiento; }
            set { _FechaVencimiento = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Menu.menu_InformacionDelPago' at Center.", repo.SURA.PC.Menu.menu_InformacionDelPagoInfo, new RecordItemIndex(0));
            repo.SURA.PC.Menu.menu_InformacionDelPago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePago.bttn_Agregar'", repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_AgregarInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_AgregarInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.bttn_Agregar' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_AgregarInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_Agregar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjetaInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjetaInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoTarjeta' with focus on 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjetaInfo, new RecordItemIndex(5));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta.PressKeys(TipoTarjeta);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePagoInfo, new RecordItemIndex(6));
            repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_TipoTarjeta'", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_TipoTarjetaInfo, new ActionTimeout(10000), new RecordItemIndex(7));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_TipoTarjetaInfo.WaitForNotExists(10000);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$NumTarjetaCred' on item 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCred'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCredInfo, new RecordItemIndex(8));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCred.Element.SetAttributeValue("TagValue", NumTarjetaCred);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumTarjetaCred' with focus on 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCred'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCredInfo, new RecordItemIndex(9));
            //repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCred.PressKeys(NumTarjetaCred);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePagoInfo, new RecordItemIndex(10));
            repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_NumTarjetaCred'", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_NumTarjetaCredInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_NumTarjetaCredInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimientoInfo, new RecordItemIndex(12));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimientoInfo, new RecordItemIndex(13));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FechaVencimiento' with focus on 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimientoInfo, new RecordItemIndex(14));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento.PressKeys(FechaVencimiento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePagoInfo, new RecordItemIndex(15));
            repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_FechaVencimiento'", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_FechaVencimientoInfo, new ActionTimeout(30000), new RecordItemIndex(16));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_FechaVencimientoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.bttn_InfoContratante' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_InfoContratanteInfo, new RecordItemIndex(17));
            repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_InfoContratante.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(18));
            Delay.Duration(2000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Actualizar' at Center.", repo.SURA.bttn_ActualizarInfo, new RecordItemIndex(20));
            repo.SURA.bttn_Actualizar.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 10s to exist. Associated repository item: 'SURA.Copy_of_lbl_TCExistente'", repo.SURA.Copy_of_lbl_TCExistenteInfo, new ActionTimeout(10000), new RecordItemIndex(21));
                repo.SURA.Copy_of_lbl_TCExistenteInfo.WaitForExists(10000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SURA.Copy_of_btn_COF_CancelarTC' at Center.", repo.SURA.Copy_of_btn_COF_CancelarTCInfo, new RecordItemIndex(22));
                repo.SURA.Copy_of_btn_COF_CancelarTC.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SURA.title_InformacionDelPago'", repo.SURA.title_InformacionDelPagoInfo, new ActionTimeout(5000), new RecordItemIndex(23));
            repo.SURA.title_InformacionDelPagoInfo.WaitForExists(5000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
