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
    ///The Cant_Cuotas recording.
    /// </summary>
    [TestModule("90304663-d05a-482a-b300-b1ad2bd01b02", ModuleType.Recording, 1)]
    public partial class Cant_Cuotas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static Cant_Cuotas instance = new Cant_Cuotas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Cant_Cuotas()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Cant_Cuotas Instance
        {
            get { return instance; }
        }

#region Variables

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

            //Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to exist. Associated repository item: 'SURA.option_Pago'", repo.SURA.option_PagoInfo, new ActionTimeout(50000), new RecordItemIndex(0));
            //repo.SURA.option_PagoInfo.WaitForExists(50000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.rb_PagoCuotas' at Center.", repo.SURA.rb_PagoCuotasInfo, new RecordItemIndex(1));
            repo.SURA.rb_PagoCuotas.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(2));
            Delay.Duration(6000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Lbl_DetallesDeLaPoliza' at Center.", repo.SURA.Lbl_DetallesDeLaPolizaInfo, new RecordItemIndex(3));
            repo.SURA.Lbl_DetallesDeLaPoliza.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.Copy_of_option_Pago'", repo.SURA.Copy_of_option_PagoInfo, new ActionTimeout(30000), new RecordItemIndex(4));
            //repo.SURA.Copy_of_option_PagoInfo.WaitForNotExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
