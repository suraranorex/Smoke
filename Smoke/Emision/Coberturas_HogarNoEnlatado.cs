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
    ///The Coberturas_HogarNoEnlatado recording.
    /// </summary>
    [TestModule("c242b6ee-3e16-4af2-9fa9-f8d24b76715e", ModuleType.Recording, 1)]
    public partial class Coberturas_HogarNoEnlatado : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static Coberturas_HogarNoEnlatado instance = new Coberturas_HogarNoEnlatado();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Coberturas_HogarNoEnlatado()
        {
            SumaAseguradaCobHogar = "100000";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Coberturas_HogarNoEnlatado Instance
        {
            get { return instance; }
        }

#region Variables

        string _SumaAseguradaCobHogar;

        /// <summary>
        /// Gets or sets the value of variable SumaAseguradaCobHogar.
        /// </summary>
        [TestVariable("44de6301-7185-465f-a87a-fe9da70f37a1")]
        public string SumaAseguradaCobHogar
        {
            get { return _SumaAseguradaCobHogar; }
            set { _SumaAseguradaCobHogar = value; }
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
        /// Gets or sets the value of variable NombreCoberturaHogar.
        /// </summary>
        [TestVariable("d8099158-6755-4296-b7d5-77a3b4412514")]
        public string NombreCoberturaHogar
        {
            get { return repo.NombreCoberturaHogar; }
            set { repo.NombreCoberturaHogar = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.OpcionCoberturaHogar' at Center.", repo.SURA.OpcionCoberturaHogarInfo, new RecordItemIndex(0));
            //repo.SURA.OpcionCoberturaHogar.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Btn_Incendio_Edificio_a_Prorrata' at Center.", repo.SURA.Btn_Incendio_Edificio_a_ProrrataInfo, new RecordItemIndex(1));
            //repo.SURA.Btn_Incendio_Edificio_a_Prorrata.Click();
            //Delay.Milliseconds(0);
            
            SeleccionaCoberturaHogar();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.SumaAseguradaCoberturaHogarAnt' at Center.", repo.SURA.SumaAseguradaCoberturaHogarAntInfo, new RecordItemIndex(3));
            //repo.SURA.SumaAseguradaCoberturaHogarAnt.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SumaAseguradaCobHogar' with focus on 'SURA.SumaAseguradaCoberturaHogarAnt'.", repo.SURA.SumaAseguradaCoberturaHogarAntInfo, new RecordItemIndex(4));
            //repo.SURA.SumaAseguradaCoberturaHogarAnt.PressKeys(SumaAseguradaCobHogar);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.lbl_CoberturasIncendio' at Center.", repo.SURA.lbl_CoberturasIncendioInfo, new RecordItemIndex(5));
            repo.SURA.lbl_CoberturasIncendio.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.SumaAseguradaCoberturaHogar'.", repo.SURA.SumaAseguradaCoberturaHogarInfo, new RecordItemIndex(7));
            repo.SURA.SumaAseguradaCoberturaHogar.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to not exist. Associated repository item: 'SURA.Copy_of_SumaAsegurada'", repo.SURA.Copy_of_SumaAseguradaInfo, new ActionTimeout(10000), new RecordItemIndex(8));
            //repo.SURA.Copy_of_SumaAseguradaInfo.WaitForNotExists(10000);
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(9));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SURA.Cotizar' at Center.", repo.SURA.CotizarInfo, new RecordItemIndex(10));
            //repo.SURA.Cotizar.MoveTo();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Cotizar' at Center.", repo.SURA.CotizarInfo, new RecordItemIndex(11));
            //repo.SURA.Cotizar.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.Cotizacion'", repo.SURA.CotizacionInfo, new ActionTimeout(30000), new RecordItemIndex(12));
            //repo.SURA.CotizacionInfo.WaitForExists(30000);
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(13));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}