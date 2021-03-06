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
    ///The TR_VARIABLE recording.
    /// </summary>
    [TestModule("073443fe-35af-4ca2-a4b9-2da95a5a16ce", ModuleType.Recording, 1)]
    public partial class TR_VARIABLE : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static TR_VARIABLE instance = new TR_VARIABLE();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TR_VARIABLE()
        {
            FranquiciaVariable = "2 %";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TR_VARIABLE Instance
        {
            get { return instance; }
        }

#region Variables

        string _FranquiciaVariable;

        /// <summary>
        /// Gets or sets the value of variable FranquiciaVariable.
        /// </summary>
        [TestVariable("fd67b5f5-1155-4882-8a5a-eb9f0f7c5e39")]
        public string FranquiciaVariable
        {
            get { return _FranquiciaVariable; }
            set { _FranquiciaVariable = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FranquiciaVariable' with focus on 'SURA.txt_Franquicia'.", repo.SURA.txt_FranquiciaInfo, new RecordItemIndex(0));
            repo.SURA.txt_Franquicia.PressKeys(FranquiciaVariable);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item 'SURA.txt_Franquicia' and assigning its value to variable 'FranquiciaVariable'.", repo.SURA.txt_FranquiciaInfo, new RecordItemIndex(1));
            FranquiciaVariable = repo.SURA.txt_Franquicia.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", FranquiciaVariable, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(3));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.lbl_InfoDelVehiculo' at 96;8.", repo.SURA.lbl_InfoDelVehiculoInfo, new RecordItemIndex(4));
            repo.SURA.lbl_InfoDelVehiculo.Click("96;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(5));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.Copy_of_txt_Franquicia'", repo.SURA.Copy_of_txt_FranquiciaInfo, new ActionTimeout(45000), new RecordItemIndex(6));
            repo.SURA.Copy_of_txt_FranquiciaInfo.WaitForNotExists(45000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
