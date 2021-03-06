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
    ///The EmisionPoliza recording.
    /// </summary>
    [TestModule("7979bdeb-98ed-4c76-bddb-41d2b24c528c", ModuleType.Recording, 1)]
    public partial class EmisionPoliza : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static EmisionPoliza instance = new EmisionPoliza();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EmisionPoliza()
        {
            NumPolizaEmitida = "";
            ValidateNroCuenta = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EmisionPoliza Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumPolizaEmitida;

        /// <summary>
        /// Gets or sets the value of variable NumPolizaEmitida.
        /// </summary>
        [TestVariable("13ee8014-30de-4a6b-8911-d337f02faa58")]
        public string NumPolizaEmitida
        {
            get { return _NumPolizaEmitida; }
            set { _NumPolizaEmitida = value; }
        }

        string _ValidateNroCuenta;

        /// <summary>
        /// Gets or sets the value of variable ValidateNroCuenta.
        /// </summary>
        [TestVariable("2c6d6c19-3362-4f10-bce5-8b6262e28878")]
        public string ValidateNroCuenta
        {
            get { return _ValidateNroCuenta; }
            set { _ValidateNroCuenta = value; }
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

            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_EmitirPoliza' at Center.", repo.SURA.bttn_EmitirPolizaInfo, new RecordItemIndex(1));
            repo.SURA.bttn_EmitirPoliza.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Aceptar' at Center.", repo.SURA.bttn_AceptarInfo, new RecordItemIndex(2));
            repo.SURA.bttn_Aceptar.Click();
            Delay.Milliseconds(0);
            
            AprobacionBloqueo();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.txt_SolicitudDePolizaContratada'", repo.SURA.txt_SolicitudDePolizaContratadaInfo, new ActionTimeout(30000), new RecordItemIndex(4));
            //repo.SURA.txt_SolicitudDePolizaContratadaInfo.WaitForExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.btn_Detalles' at Center.", repo.SURA.btn_DetallesInfo, new RecordItemIndex(5));
            //repo.SURA.btn_Detalles.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.btn_AprobacionEspecial' at Center.", repo.SURA.btn_AprobacionEspecialInfo, new RecordItemIndex(6));
            //repo.SURA.btn_AprobacionEspecial.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA_ContinueOnFail.bttn_Aceptar' at Center.", repo.SURA_ContinueOnFail.bttn_AceptarInfo, new RecordItemIndex(7));
            //repo.SURA_ContinueOnFail.bttn_Aceptar.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Aceptar4' at Center.", repo.SURA.bttn_Aceptar4Info, new RecordItemIndex(8));
            //repo.SURA.bttn_Aceptar4.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_EmitirPoliza' at Center.", repo.SURA.bttn_EmitirPolizaInfo, new RecordItemIndex(9));
            //repo.SURA.bttn_EmitirPoliza.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Aceptar' at Center.", repo.SURA.bttn_AceptarInfo, new RecordItemIndex(10));
            //repo.SURA.bttn_Aceptar.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'SURA.txt_SolicitudDePolizaContratada'", repo.SURA.txt_SolicitudDePolizaContratadaInfo, new ActionTimeout(40000), new RecordItemIndex(11));
            repo.SURA.txt_SolicitudDePolizaContratadaInfo.WaitForExists(40000);
            
            // La poliza emitida es:
            Report.Log(ReportLevel.Info, "Section", "La poliza emitida es:", new RecordItemIndex(12));
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.NumeroDePolizaEmitida' and assigning the part of its value captured by '[0-9]+' to variable 'NumPolizaEmitida'.", repo.SURA.NumeroDePolizaEmitidaInfo, new RecordItemIndex(14));
            NumPolizaEmitida = repo.SURA.NumeroDePolizaEmitida.Element.GetAttributeValueText("InnerText", new Regex("[0-9]+"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.validate_NroCuenta' and assigning its value to variable 'ValidateNroCuenta'.", repo.SURA.validate_NroCuentaInfo, new RecordItemIndex(15));
            ValidateNroCuenta = repo.SURA.validate_NroCuenta.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "El número de poliza emitida es:", new RecordItemIndex(16));
            
            // El número de poliza emitida es:
            Report.Log(ReportLevel.Info, "User", NumPolizaEmitida, new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "User", "Para la cuenta:", new RecordItemIndex(18));
            
            // Para la cuenta:
            Report.Log(ReportLevel.Info, "User", ValidateNroCuenta, new RecordItemIndex(19));
            
            guardarNumPoliza();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
