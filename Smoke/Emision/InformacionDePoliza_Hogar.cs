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
    ///The InformacionDePoliza_Hogar recording.
    /// </summary>
    [TestModule("aa6b25e3-ee29-4cdf-9ccc-3cdd15e89bc2", ModuleType.Recording, 1)]
    public partial class InformacionDePoliza_Hogar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static InformacionDePoliza_Hogar instance = new InformacionDePoliza_Hogar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionDePoliza_Hogar()
        {
            MetodoDePago = "Cupón";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionDePoliza_Hogar Instance
        {
            get { return instance; }
        }

#region Variables

        string _MetodoDePago;

        /// <summary>
        /// Gets or sets the value of variable MetodoDePago.
        /// </summary>
        [TestVariable("c1ea9701-23ec-4aea-916d-36e14bff1a84")]
        public string MetodoDePago
        {
            get { return _MetodoDePago; }
            set { _MetodoDePago = value; }
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

            Report.Log(ReportLevel.Info, "User", MetodoDePago, new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '' on item 'SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago'.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePagoInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago.Element.SetAttributeValue("Value", "");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$MetodoDePago' with focus on 'SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago'.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePagoInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago.PressKeys(MetodoDePago);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Pantalla' at UpperRight.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.PantallaInfo, new RecordItemIndex(3));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Pantalla.Click(Location.UpperRight);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Lbl_DetallesDeLaPoliza' at Center.", repo.SURA.Lbl_DetallesDeLaPolizaInfo, new RecordItemIndex(4));
            repo.SURA.Lbl_DetallesDeLaPoliza.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePago'", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePagoInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePagoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Lbl_DetallesDeLaPoliza' at Center.", repo.SURA.Lbl_DetallesDeLaPolizaInfo, new RecordItemIndex(6));
            repo.SURA.Lbl_DetallesDeLaPoliza.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Pantalla' at UpperRight.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.PantallaInfo, new RecordItemIndex(7));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Pantalla.Click(Location.UpperRight);
            //Delay.Milliseconds(0);
            
            // Nota: se comentarion los siguiente Items y se pasaron a los IF de Cuotas y al Continue
            Report.Log(ReportLevel.Info, "Section", "Nota: se comentarion los siguiente Items y se pasaron a los IF de Cuotas y al Continue", new RecordItemIndex(8));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotas' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotasInfo, new RecordItemIndex(9));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotas.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 4s to exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePoliza.option_Pago'", repo.SURA.PC.Emision.Generales.InformacionDePoliza.option_PagoInfo, new ActionTimeout(4000), new RecordItemIndex(10));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.option_PagoInfo.WaitForExists(4000);
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(11));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1.5s.", new RecordItemIndex(12));
            //Delay.Duration(1500, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(13));
            //repo.SURA.bttn_Siguiente.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Vivienda') on item 'SURA.txt_Vivienda'.", repo.SURA.txt_ViviendaInfo, new RecordItemIndex(14));
            //Validate.AttributeEqual(repo.SURA.txt_ViviendaInfo, "InnerText", "Vivienda");
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
