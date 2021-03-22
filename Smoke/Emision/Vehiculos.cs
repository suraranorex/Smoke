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
    ///The Vehiculos recording.
    /// </summary>
    [TestModule("263947f6-de59-4855-8e30-80e21b4c972d", ModuleType.Recording, 1)]
    public partial class Vehiculos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static Vehiculos instance = new Vehiculos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Vehiculos()
        {
            Anio = "2009";
            Marca = "CHEVROLET";
            Modelo = "ASTRA";
            Actividad = "Sin Actividad";
            SumaAsegurada = "400000";
            Patente = "ZZZ999";
            Motor = "ABH134H8812";
            Chasis = "CA52MN31912";
            Producto = "A - Responsabilidad Civil Unicamente";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Vehiculos Instance
        {
            get { return instance; }
        }

#region Variables

        string _Anio;

        /// <summary>
        /// Gets or sets the value of variable Anio.
        /// </summary>
        [TestVariable("e4d60489-73eb-4a96-8b98-fe56bd31e51a")]
        public string Anio
        {
            get { return _Anio; }
            set { _Anio = value; }
        }

        string _Marca;

        /// <summary>
        /// Gets or sets the value of variable Marca.
        /// </summary>
        [TestVariable("55323f14-f2e3-4a2d-adb3-1c1c9472cd08")]
        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        string _Modelo;

        /// <summary>
        /// Gets or sets the value of variable Modelo.
        /// </summary>
        [TestVariable("039c448b-0048-4018-a6b9-2c57ba0812d0")]
        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        string _Actividad;

        /// <summary>
        /// Gets or sets the value of variable Actividad.
        /// </summary>
        [TestVariable("68667be4-e751-4ae2-8682-f9cc584ea636")]
        public string Actividad
        {
            get { return _Actividad; }
            set { _Actividad = value; }
        }

        string _SumaAsegurada;

        /// <summary>
        /// Gets or sets the value of variable SumaAsegurada.
        /// </summary>
        [TestVariable("0df2ed1c-41e5-4789-af35-ce0fad29aa91")]
        public string SumaAsegurada
        {
            get { return _SumaAsegurada; }
            set { _SumaAsegurada = value; }
        }

        string _Patente;

        /// <summary>
        /// Gets or sets the value of variable Patente.
        /// </summary>
        [TestVariable("9fb1bcfa-0f4c-4f05-b50f-182916997cf5")]
        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }

        string _Motor;

        /// <summary>
        /// Gets or sets the value of variable Motor.
        /// </summary>
        [TestVariable("af92f7a6-cb98-4088-b6d2-e6d3d9afc2f5")]
        public string Motor
        {
            get { return _Motor; }
            set { _Motor = value; }
        }

        string _Chasis;

        /// <summary>
        /// Gets or sets the value of variable Chasis.
        /// </summary>
        [TestVariable("da2c6687-231b-431a-a1a0-6e3927626c97")]
        public string Chasis
        {
            get { return _Chasis; }
            set { _Chasis = value; }
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
        /// Gets or sets the value of variable Producto.
        /// </summary>
        [TestVariable("3769fc9c-6a52-4f96-8f50-ca462fd65275")]
        public string Producto
        {
            get { return repo.Producto; }
            set { repo.Producto = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anio' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Anio'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_AnioInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Anio.PressKeys(Anio);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Anio'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo, new ActionTimeout(45000), new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Marca' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MarcaInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca.PressKeys(Marca, 10);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MarcaInfo, new RecordItemIndex(6));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(7));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(8));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(9));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Marca'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MarcaInfo, new ActionTimeout(45000), new RecordItemIndex(10));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MarcaInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Modelo' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ModeloInfo, new RecordItemIndex(11));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo.PressKeys(Modelo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(12));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ModeloInfo, new RecordItemIndex(13));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(14));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(15));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(16));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Modelo'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ModeloInfo, new ActionTimeout(45000), new RecordItemIndex(17));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ModeloInfo.WaitForNotExists(45000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(18));
            //Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(19));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad.PressKeys("{Back}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Actividad' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(20));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad.PressKeys(Actividad);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(21));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Actividad'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ActividadInfo, new ActionTimeout(45000), new RecordItemIndex(22));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ActividadInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(23));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SumaAsegurada' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(24));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada.PressKeys(SumaAsegurada);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(25));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(26));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAsegurada'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo, new ActionTimeout(45000), new RecordItemIndex(27));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo.WaitForNotExists(45000);
            
            // --------------------------------Campos Opcionales
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Campos Opcionales", new RecordItemIndex(28));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Patente' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Patente'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_PatenteInfo, new RecordItemIndex(29));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Patente.PressKeys(Patente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(30));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Patente'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_PatenteInfo, new ActionTimeout(45000), new RecordItemIndex(31));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_PatenteInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(32));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(33));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Motor' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(34));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor.PressKeys(Motor);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(35));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Motor'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MotorInfo, new ActionTimeout(45000), new RecordItemIndex(36));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MotorInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(37));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(38));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Chasis' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(39));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis.PressKeys(Chasis);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(40));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Chasis'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ChasisInfo, new ActionTimeout(45000), new RecordItemIndex(41));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ChasisInfo.WaitForNotExists(45000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(42));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Producto' with focus on 'SURA.txtbox_Producto'.", repo.SURA.txtbox_ProductoInfo, new RecordItemIndex(43));
            repo.SURA.txtbox_Producto.PressKeys(Producto);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(44));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.Copy_of_txtbox_Producto'", repo.SURA.Copy_of_txtbox_ProductoInfo, new ActionTimeout(45000), new RecordItemIndex(45));
            repo.SURA.Copy_of_txtbox_ProductoInfo.WaitForNotExists(45000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(46));
            
            // --------------------------------Cambio a Siguiente Pantalla
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cambio a Siguiente Pantalla", new RecordItemIndex(47));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(48));
            //repo.SURA.bttn_Siguiente.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'SURA.txt_ComisionesDescuentos'", repo.SURA.txt_ComisionesDescuentosInfo, new ActionTimeout(45000), new RecordItemIndex(49));
            //repo.SURA.txt_ComisionesDescuentosInfo.WaitForExists(45000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
