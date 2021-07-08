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
    ///The Vehiculo_Con_InfoAuto recording.
    /// </summary>
    [TestModule("6128e8c4-8594-4be2-9df9-daf732412e61", ModuleType.Recording, 1)]
    public partial class Vehiculo_Con_InfoAuto : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static Vehiculo_Con_InfoAuto instance = new Vehiculo_Con_InfoAuto();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Vehiculo_Con_InfoAuto()
        {
            AnioActual = "2009";
            Marca = "CHEVROLET";
            Modelo = "ASTRA";
            Actividad = "Sin Actividad";
            SumaAsegurada = "400000";
            Patente = "ZZZ999";
            Motor = "ABH134H8812";
            Chasis = "CA52MN31912";
            Producto = "A - Responsabilidad Civil Unicamente";
            CodInfoAuto = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Vehiculo_Con_InfoAuto Instance
        {
            get { return instance; }
        }

#region Variables

        string _AnioActual;

        /// <summary>
        /// Gets or sets the value of variable AnioActual.
        /// </summary>
        [TestVariable("a98494e1-5423-4404-bc52-37f21dba2dd7")]
        public string AnioActual
        {
            get { return _AnioActual; }
            set { _AnioActual = value; }
        }

        string _Marca;

        /// <summary>
        /// Gets or sets the value of variable Marca.
        /// </summary>
        [TestVariable("dad310c8-29d0-4e2b-a19f-eb9155eb3ae1")]
        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        string _Modelo;

        /// <summary>
        /// Gets or sets the value of variable Modelo.
        /// </summary>
        [TestVariable("07bfd052-750e-41a6-9650-2e1e76024370")]
        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        string _Actividad;

        /// <summary>
        /// Gets or sets the value of variable Actividad.
        /// </summary>
        [TestVariable("bff49c32-c4ea-4632-8b6e-50ea69fc982d")]
        public string Actividad
        {
            get { return _Actividad; }
            set { _Actividad = value; }
        }

        string _SumaAsegurada;

        /// <summary>
        /// Gets or sets the value of variable SumaAsegurada.
        /// </summary>
        [TestVariable("27e516b9-e60d-4b16-b83f-f0a40e875770")]
        public string SumaAsegurada
        {
            get { return _SumaAsegurada; }
            set { _SumaAsegurada = value; }
        }

        string _Patente;

        /// <summary>
        /// Gets or sets the value of variable Patente.
        /// </summary>
        [TestVariable("e1f15e04-5f36-4132-a2f6-70645cd7e450")]
        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }

        string _Motor;

        /// <summary>
        /// Gets or sets the value of variable Motor.
        /// </summary>
        [TestVariable("d6c2597b-d950-4545-891d-a5ad75ede4c7")]
        public string Motor
        {
            get { return _Motor; }
            set { _Motor = value; }
        }

        string _Chasis;

        /// <summary>
        /// Gets or sets the value of variable Chasis.
        /// </summary>
        [TestVariable("f2a08c50-9a11-425b-9773-611c9983ed9e")]
        public string Chasis
        {
            get { return _Chasis; }
            set { _Chasis = value; }
        }

        string _CodInfoAuto;

        /// <summary>
        /// Gets or sets the value of variable CodInfoAuto.
        /// </summary>
        [TestVariable("3bd3f00c-13ec-4e3d-8ba7-3745b2a76b1b")]
        public string CodInfoAuto
        {
            get { return _CodInfoAuto; }
            set { _CodInfoAuto = value; }
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
        [TestVariable("c3da7e24-78ee-40f8-8724-ef5122bac1f8")]
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$AnioActual' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Anio'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_AnioInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Anio.PressKeys(AnioActual);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Anio'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo, new ActionTimeout(45000), new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txt_CodInfoAuto' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txt_CodInfoAutoInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txt_CodInfoAuto.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CodInfoAuto' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txt_CodInfoAuto'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txt_CodInfoAutoInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txt_CodInfoAuto.PressKeys(CodInfoAuto);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txt_CodInfoAuto'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txt_CodInfoAutoInfo, new ActionTimeout(30000), new RecordItemIndex(6));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txt_CodInfoAutoInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Marca' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MarcaInfo, new RecordItemIndex(7));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca.PressKeys(Marca, 10);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(8));
            //Delay.Duration(500, false);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MarcaInfo, new RecordItemIndex(9));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca.PressKeys("{Return}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(10));
            //Delay.Duration(500, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(11));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(12));
            //Delay.Duration(500, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Marca'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MarcaInfo, new ActionTimeout(45000), new RecordItemIndex(13));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MarcaInfo.WaitForNotExists(45000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Modelo' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ModeloInfo, new RecordItemIndex(14));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo.PressKeys(Modelo);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(15));
            //Delay.Duration(500, false);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ModeloInfo, new RecordItemIndex(16));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo.PressKeys("{Return}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(17));
            //Delay.Duration(500, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(18));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(19));
            //Delay.Duration(500, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Modelo'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ModeloInfo, new ActionTimeout(45000), new RecordItemIndex(20));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ModeloInfo.WaitForNotExists(45000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(21));
            //Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(22));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad.PressKeys("{Back}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Actividad' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(23));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad.PressKeys(Actividad);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(24));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Actividad'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ActividadInfo, new ActionTimeout(45000), new RecordItemIndex(25));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ActividadInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(26));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SumaAsegurada' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(27));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada.PressKeys(SumaAsegurada);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(28));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(29));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAsegurada'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo, new ActionTimeout(45000), new RecordItemIndex(30));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo.WaitForNotExists(45000);
            
            // --------------------------------Campos Opcionales
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Campos Opcionales", new RecordItemIndex(31));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Patente' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Patente'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_PatenteInfo, new RecordItemIndex(32));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Patente.PressKeys(Patente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(33));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Patente'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_PatenteInfo, new ActionTimeout(45000), new RecordItemIndex(34));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_PatenteInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(35));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(36));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Motor' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(37));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor.PressKeys(Motor);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(38));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Motor'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MotorInfo, new ActionTimeout(45000), new RecordItemIndex(39));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MotorInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(40));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(41));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Chasis' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(42));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis.PressKeys(Chasis);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(43));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Chasis'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ChasisInfo, new ActionTimeout(45000), new RecordItemIndex(44));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ChasisInfo.WaitForNotExists(45000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(45));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Producto' with focus on 'SURA.txtbox_Producto'.", repo.SURA.txtbox_ProductoInfo, new RecordItemIndex(46));
            repo.SURA.txtbox_Producto.PressKeys(Producto);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(47));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.Copy_of_txtbox_Producto'", repo.SURA.Copy_of_txtbox_ProductoInfo, new ActionTimeout(45000), new RecordItemIndex(48));
            repo.SURA.Copy_of_txtbox_ProductoInfo.WaitForNotExists(45000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(49));
            
            // --------------------------------Cambio a Siguiente Pantalla
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cambio a Siguiente Pantalla", new RecordItemIndex(50));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(51));
            //repo.SURA.bttn_Siguiente.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'SURA.txt_ComisionesDescuentos'", repo.SURA.txt_ComisionesDescuentosInfo, new ActionTimeout(45000), new RecordItemIndex(52));
            //repo.SURA.txt_ComisionesDescuentosInfo.WaitForExists(45000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
