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
    ///The ConfirmarReversion recording.
    /// </summary>
    [TestModule("fde3da18-809b-432f-b71f-9500deb8553a", ModuleType.Recording, 1)]
    public partial class ConfirmarReversion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static ConfirmarReversion instance = new ConfirmarReversion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ConfirmarReversion()
        {
            MotivoReversion = "Contracargo Tarjeta";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ConfirmarReversion Instance
        {
            get { return instance; }
        }

#region Variables

        string _MotivoReversion;

        /// <summary>
        /// Gets or sets the value of variable MotivoReversion.
        /// </summary>
        [TestVariable("5a3c29ea-62f7-4c5c-985e-e399931b35c3")]
        public string MotivoReversion
        {
            get { return _MotivoReversion; }
            set { _MotivoReversion = value; }
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
        /// Gets or sets the value of variable NUMPOLIZA_REVERTIR.
        /// </summary>
        [TestVariable("ec206af3-54d1-44c2-86ad-9c9b8fabcad0")]
        public string NUMPOLIZA_REVERTIR
        {
            get { return repo.NUMPOLIZA_REVERTIR; }
            set { repo.NUMPOLIZA_REVERTIR = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Acciones' at Center.", repo.SURA.AccionesInfo, new RecordItemIndex(0));
            repo.SURA.Acciones.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Revertir' at Center.", repo.SURA.RevertirInfo, new RecordItemIndex(1));
            repo.SURA.Revertir.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.Reversa.bttn_Motivo' at 23;6.", repo.SURA.BC.Reversa.bttn_MotivoInfo, new RecordItemIndex(2));
            repo.SURA.BC.Reversa.bttn_Motivo.Click("23;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.BC.Reversa.bttn_Motivo'.", repo.SURA.BC.Reversa.bttn_MotivoInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.SURA.BC.Reversa.bttn_Motivo);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$MotivoReversion' with focus on 'SURA.BC.Reversa.bttn_Motivo'.", repo.SURA.BC.Reversa.bttn_MotivoInfo, new RecordItemIndex(4));
            repo.SURA.BC.Reversa.bttn_Motivo.PressKeys(MotivoReversion);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.Reversa.txt_ReversionDePago' at Center.", repo.SURA.BC.Reversa.txt_ReversionDePagoInfo, new RecordItemIndex(5));
            repo.SURA.BC.Reversa.txt_ReversionDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.BC.Reversa.Copy_of_bttn_Motivo'", repo.SURA.BC.Reversa.Copy_of_bttn_MotivoInfo, new ActionTimeout(30000), new RecordItemIndex(6));
            repo.SURA.BC.Reversa.Copy_of_bttn_MotivoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Aceptar' at Center.", repo.SURA.bttn_AceptarInfo, new RecordItemIndex(8));
            repo.SURA.bttn_Aceptar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SURA.txt_Revertido'.", repo.SURA.txt_RevertidoInfo, new RecordItemIndex(9));
            Validate.Exists(repo.SURA.txt_RevertidoInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
