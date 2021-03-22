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
    ///The InformacionDePoliza_Motor recording.
    /// </summary>
    [TestModule("54afdca2-aff3-40f7-a8e1-a66fbaf0dfc1", ModuleType.Recording, 1)]
    public partial class InformacionDePoliza_Motor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static InformacionDePoliza_Motor instance = new InformacionDePoliza_Motor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionDePoliza_Motor()
        {
            CantVehiculos = "5 o más vehículos";
            MetodoDePago = "Cupón";
            TipoPlazo = "3 meses";
            FechaInicio = "17/5/2020";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionDePoliza_Motor Instance
        {
            get { return instance; }
        }

#region Variables

        string _CantVehiculos;

        /// <summary>
        /// Gets or sets the value of variable CantVehiculos.
        /// </summary>
        [TestVariable("7856920b-be3e-4ec4-9ec4-e9bed92a3e8b")]
        public string CantVehiculos
        {
            get { return _CantVehiculos; }
            set { _CantVehiculos = value; }
        }

        string _MetodoDePago;

        /// <summary>
        /// Gets or sets the value of variable MetodoDePago.
        /// </summary>
        [TestVariable("e640fef2-81fc-4b81-8a41-46eecb67ccba")]
        public string MetodoDePago
        {
            get { return _MetodoDePago; }
            set { _MetodoDePago = value; }
        }

        string _TipoPlazo;

        /// <summary>
        /// Gets or sets the value of variable TipoPlazo.
        /// </summary>
        [TestVariable("1f69bc36-a61e-4806-acde-c6c16975909a")]
        public string TipoPlazo
        {
            get { return _TipoPlazo; }
            set { _TipoPlazo = value; }
        }

        string _FechaInicio;

        /// <summary>
        /// Gets or sets the value of variable FechaInicio.
        /// </summary>
        [TestVariable("ae6ef970-4ee5-4219-9f6a-e9dbae3598fb")]
        public string FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
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
        /// Gets or sets the value of variable OPCION_PAGOCUOTAS.
        /// </summary>
        [TestVariable("10e73b3e-5f3c-4506-a282-bfc64eae503b")]
        public string OPCION_PAGOCUOTAS
        {
            get { return repo.OPCION_PAGOCUOTAS; }
            set { repo.OPCION_PAGOCUOTAS = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos' at Center.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculosInfo, new RecordItemIndex(0));
            //repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos'.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculosInfo, new RecordItemIndex(1));
            //Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos'.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculosInfo, new RecordItemIndex(2));
            //repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos.PressKeys("{Back}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CantVehiculos' with focus on 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos'.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculosInfo, new RecordItemIndex(3));
            //repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos.PressKeys(CantVehiculos);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Pantalla' at UpperRight.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.PantallaInfo, new RecordItemIndex(4));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Pantalla.Click(Location.UpperRight);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_list_CantVehiculos'", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_list_CantVehiculosInfo, new ActionTimeout(15000), new RecordItemIndex(5));
            //repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_list_CantVehiculosInfo.WaitForNotExists(15000);
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_TipoPlazo'.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_TipoPlazoInfo, new RecordItemIndex(6));
                repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_TipoPlazo.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence from variable '$TipoPlazo' with focus on 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_TipoPlazo'.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_TipoPlazoInfo, new RecordItemIndex(7));
                repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_TipoPlazo.PressKeys(TipoPlazo);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Lbl_DetallesDeLaPoliza' at UpperRight.", repo.SURA.Lbl_DetallesDeLaPolizaInfo, new RecordItemIndex(8));
            repo.SURA.Lbl_DetallesDeLaPoliza.Click(Location.UpperRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_txt_TipoPlazo'", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_txt_TipoPlazoInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_txt_TipoPlazoInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_Fecha_Inicio'.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_Fecha_InicioInfo, new RecordItemIndex(10));
            //repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_Fecha_Inicio.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FechaInicio' with focus on 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_Fecha_Inicio'.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_Fecha_InicioInfo, new RecordItemIndex(11));
            //repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.txt_Fecha_Inicio.PressKeys(FechaInicio);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Lbl_DetallesDeLaPoliza' at UpperRight.", repo.SURA.Lbl_DetallesDeLaPolizaInfo, new RecordItemIndex(12));
            //repo.SURA.Lbl_DetallesDeLaPoliza.Click(Location.UpperRight);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_txt_Fecha_Inicio'", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_txt_Fecha_InicioInfo, new ActionTimeout(30000), new RecordItemIndex(13));
            //repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_txt_Fecha_InicioInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePagoInfo, new RecordItemIndex(14));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago'.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePagoInfo, new RecordItemIndex(15));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$MetodoDePago' with focus on 'SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago'.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePagoInfo, new RecordItemIndex(16));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago.PressKeys(MetodoDePago);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Lbl_DetallesDeLaPoliza' at UpperRight.", repo.SURA.Lbl_DetallesDeLaPolizaInfo, new RecordItemIndex(17));
            repo.SURA.Lbl_DetallesDeLaPoliza.Click(Location.UpperRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePago'", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePagoInfo, new ActionTimeout(40000), new RecordItemIndex(18));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePagoInfo.WaitForNotExists(40000);
            
            // NOTA: se comentaron los sig items por la condición de CantCuotas Si o No
            Report.Log(ReportLevel.Info, "Section", "NOTA: se comentaron los sig items por la condición de CantCuotas Si o No", new RecordItemIndex(19));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotas' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotasInfo, new RecordItemIndex(20));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotas.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePoliza.option_Pago'", repo.SURA.PC.Emision.Generales.InformacionDePoliza.option_PagoInfo, new ActionTimeout(15000), new RecordItemIndex(21));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.option_PagoInfo.WaitForExists(15000);
            
            // --------------------------Capturas de pantalla
            Report.Log(ReportLevel.Info, "Section", "--------------------------Capturas de pantalla", new RecordItemIndex(22));
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(23));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(24));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(25));
            //repo.SURA.bttn_Siguiente.MoveTo();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(26));
            //repo.SURA.bttn_Siguiente.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.txt_ConductoresPropietarios'", repo.SURA.txt_ConductoresPropietariosInfo, new ActionTimeout(30000), new RecordItemIndex(27));
            //repo.SURA.txt_ConductoresPropietariosInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
