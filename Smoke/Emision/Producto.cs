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
    ///The Producto recording.
    /// </summary>
    [TestModule("19ada6ca-8aec-4da0-a855-7d93e21bfb16", ModuleType.Recording, 1)]
    public partial class Producto : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static Producto instance = new Producto();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Producto()
        {
            Oferta = "AP Total";
            Extension = "Jornada Laboral";
            Ambito = "República Argentina";
            TomadorComoBenef = "No";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Producto Instance
        {
            get { return instance; }
        }

#region Variables

        string _Oferta;

        /// <summary>
        /// Gets or sets the value of variable Oferta.
        /// </summary>
        [TestVariable("1902246d-a2b3-492c-b9fa-408cb7c63df0")]
        public string Oferta
        {
            get { return _Oferta; }
            set { _Oferta = value; }
        }

        string _Extension;

        /// <summary>
        /// Gets or sets the value of variable Extension.
        /// </summary>
        [TestVariable("1b8a9ef5-a270-40d5-8846-26e3e35b687a")]
        public string Extension
        {
            get { return _Extension; }
            set { _Extension = value; }
        }

        string _Ambito;

        /// <summary>
        /// Gets or sets the value of variable Ambito.
        /// </summary>
        [TestVariable("923381ae-674b-436d-b5a2-78aa6c687d53")]
        public string Ambito
        {
            get { return _Ambito; }
            set { _Ambito = value; }
        }

        string _TomadorComoBenef;

        /// <summary>
        /// Gets or sets the value of variable TomadorComoBenef.
        /// </summary>
        [TestVariable("90cd330a-763c-4fa6-bc9d-60753209e90f")]
        public string TomadorComoBenef
        {
            get { return _TomadorComoBenef; }
            set { _TomadorComoBenef = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Oferta' with focus on 'SURA.PC.Emision.PolizaAP.Producto.txtbox_SeleccionDeOfertas'.", repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_SeleccionDeOfertasInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_SeleccionDeOfertas.PressKeys(Oferta);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Producto.Pantalla' at CenterRight.", repo.SURA.PC.Emision.PolizaAP.Producto.PantallaInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.PolizaAP.Producto.Pantalla.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_SeleccionDeOfertas'", repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_SeleccionDeOfertasInfo, new ActionTimeout(15000), new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_SeleccionDeOfertasInfo.WaitForNotExists(15000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Extension' with focus on 'SURA.PC.Emision.PolizaAP.Producto.txtbox_ExtensionDeCobertura'.", repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_ExtensionDeCoberturaInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_ExtensionDeCobertura.PressKeys(Extension);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Producto.Pantalla' at CenterRight.", repo.SURA.PC.Emision.PolizaAP.Producto.PantallaInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.PolizaAP.Producto.Pantalla.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_ExtensionDeCobertura'", repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_ExtensionDeCoberturaInfo, new ActionTimeout(15000), new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_ExtensionDeCoberturaInfo.WaitForNotExists(15000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Ambito' with focus on 'SURA.PC.Emision.PolizaAP.Producto.txtbox_AmbitoDeCobertura'.", repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_AmbitoDeCoberturaInfo, new RecordItemIndex(6));
            repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_AmbitoDeCobertura.PressKeys(Ambito);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Producto.Pantalla' at CenterRight.", repo.SURA.PC.Emision.PolizaAP.Producto.PantallaInfo, new RecordItemIndex(7));
            repo.SURA.PC.Emision.PolizaAP.Producto.Pantalla.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_AmbitoDeCobertura'", repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_AmbitoDeCoberturaInfo, new ActionTimeout(15000), new RecordItemIndex(8));
            repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_AmbitoDeCoberturaInfo.WaitForNotExists(15000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiario'.", repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiarioInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiario);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TomadorComoBenef' with focus on 'SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiario'.", repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiarioInfo, new RecordItemIndex(10));
            repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiario.PressKeys(TomadorComoBenef);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Producto.Pantalla' at CenterRight.", repo.SURA.PC.Emision.PolizaAP.Producto.PantallaInfo, new RecordItemIndex(11));
            repo.SURA.PC.Emision.PolizaAP.Producto.Pantalla.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_TomadorComoBeneficiario'", repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_TomadorComoBeneficiarioInfo, new ActionTimeout(15000), new RecordItemIndex(12));
            repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_TomadorComoBeneficiarioInfo.WaitForNotExists(15000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(14));
            repo.SURA.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SURA.txt_Personas'", repo.SURA.txt_PersonasInfo, new ActionTimeout(20000), new RecordItemIndex(15));
            repo.SURA.txt_PersonasInfo.WaitForExists(20000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}