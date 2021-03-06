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
    ///The RenombrarCSV recording.
    /// </summary>
    [TestModule("d7995290-d704-4ec8-9154-245069a6a642", ModuleType.Recording, 1)]
    public partial class RenombrarCSV : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static RenombrarCSV instance = new RenombrarCSV();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RenombrarCSV()
        {
            archivoSalida = "polizas.csv";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RenombrarCSV Instance
        {
            get { return instance; }
        }

#region Variables

        string _archivoSalida;

        /// <summary>
        /// Gets or sets the value of variable archivoSalida.
        /// </summary>
        [TestVariable("6fb69339-f00f-41bb-891d-73624be18a87")]
        public string archivoSalida
        {
            get { return _archivoSalida; }
            set { _archivoSalida = value; }
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

            RenombraArchivoCSV(archivoSalida);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
