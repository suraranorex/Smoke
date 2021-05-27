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

namespace Smoke.Menu
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MenuLatPagosRevert recording.
    /// </summary>
    [TestModule("79298b40-47aa-40e4-b09c-fa13853760b8", ModuleType.Recording, 1)]
    public partial class MenuLatPagosRevert : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static MenuLatPagosRevert instance = new MenuLatPagosRevert();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MenuLatPagosRevert()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MenuLatPagosRevert Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttnLateral_Pagos' at Center.", repo.SURA.bttnLateral_PagosInfo, new RecordItemIndex(0));
            repo.SURA.bttnLateral_Pagos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.txt_Pagos'", repo.SURA.txt_PagosInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SURA.txt_PagosInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
