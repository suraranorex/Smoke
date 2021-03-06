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
    ///The BuscarProveedor recording.
    /// </summary>
    [TestModule("64e36552-c831-42c6-b747-23a15db04221", ModuleType.Recording, 1)]
    public partial class BuscarProveedor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static BuscarProveedor instance = new BuscarProveedor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BuscarProveedor()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BuscarProveedor Instance
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '30711707960' with focus on 'SURA.txt_DocumentoProveedor'.", repo.SURA.txt_DocumentoProveedorInfo, new RecordItemIndex(0));
            repo.SURA.txt_DocumentoProveedor.PressKeys("30711707960");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.lbl_BuscarProveedor' at Center.", repo.SURA.lbl_BuscarProveedorInfo, new RecordItemIndex(1));
            repo.SURA.lbl_BuscarProveedor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.Copy_of_txt_DocumentoProveedor'", repo.SURA.Copy_of_txt_DocumentoProveedorInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.SURA.Copy_of_txt_DocumentoProveedorInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Btn_BuscarProveedor' at Center.", repo.SURA.Btn_BuscarProveedorInfo, new RecordItemIndex(3));
            repo.SURA.Btn_BuscarProveedor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SURA.lbl_Proveedor_16VNEUMATICOSSRL'", repo.SURA.lbl_Proveedor_16VNEUMATICOSSRLInfo, new ActionTimeout(5000), new RecordItemIndex(4));
            repo.SURA.lbl_Proveedor_16VNEUMATICOSSRLInfo.WaitForExists(5000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
