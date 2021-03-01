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

namespace Smoke.CrearCuentaSinValidarDNI
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BuscarGrupo recording.
    /// </summary>
    [TestModule("4afaa211-a731-484e-93b8-81ad0d2d08ed", ModuleType.Recording, 1)]
    public partial class BuscarGrupo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static BuscarGrupo instance = new BuscarGrupo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BuscarGrupo()
        {
            PAS = "2302";
            PASNombre = "";
            NroCuenta = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BuscarGrupo Instance
        {
            get { return instance; }
        }

#region Variables

        string _PASNombre;

        /// <summary>
        /// Gets or sets the value of variable PASNombre.
        /// </summary>
        [TestVariable("d1fba827-e14d-499b-b9e9-189cfe13a5a2")]
        public string PASNombre
        {
            get { return _PASNombre; }
            set { _PASNombre = value; }
        }

        string _NroCuenta;

        /// <summary>
        /// Gets or sets the value of variable NroCuenta.
        /// </summary>
        [TestVariable("0553bcfd-af1e-4f96-b6e1-9a2e386e303a")]
        public string NroCuenta
        {
            get { return _NroCuenta; }
            set { _NroCuenta = value; }
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
        /// Gets or sets the value of variable NombreProductor.
        /// </summary>
        [TestVariable("556488d1-671f-4f0c-8aed-02af2f099e6e")]
        public string NombreProductor
        {
            get { return repo.NombreProductor; }
            set { repo.NombreProductor = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PAS.
        /// </summary>
        [TestVariable("7d0ae978-5edd-46b1-8167-e321254057f5")]
        public string PAS
        {
            get { return repo.PAS; }
            set { repo.PAS = value; }
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

            // **** Buscar Grupo ****
            Report.Log(ReportLevel.Info, "Section", "**** Buscar Grupo ****", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Txt_Cod_PAS' at 57;15.", repo.ApplicationUnderTest.Txt_Cod_PASInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Txt_Cod_PAS.Click("57;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.Txt_Cod_PAS'.", repo.ApplicationUnderTest.Txt_Cod_PASInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.Txt_Cod_PAS);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PAS' with focus on 'ApplicationUnderTest.Txt_Cod_PAS'.", repo.ApplicationUnderTest.Txt_Cod_PASInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Txt_Cod_PAS.PressKeys(PAS);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_BuscarPAS' at Center.", repo.ApplicationUnderTest.Btn_BuscarPASInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.Btn_BuscarPAS.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SeleccionarPAS' at 38;13.", repo.ApplicationUnderTest.SeleccionarPASInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.SeleccionarPAS.Click("38;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(6));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.FlechaCodPAS' at 7;7.", repo.ApplicationUnderTest.XTableLayout.FlechaCodPASInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.XTableLayout.FlechaCodPAS.Click("7;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txt_CodPas' at Center.", repo.ApplicationUnderTest.txt_CodPasInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.txt_CodPas.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.FlechaCodPAS' at Center.", repo.ApplicationUnderTest.XTableLayout.FlechaCodPASInfo, new RecordItemIndex(9));
            //repo.ApplicationUnderTest.XTableLayout.FlechaCodPAS.Click();
            //Delay.Milliseconds(0);
            
            //PASNombreProductor();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "User", PASNombre, new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PAS' with focus on 'ApplicationUnderTest.txt_CodPas'.", repo.ApplicationUnderTest.txt_CodPasInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.txt_CodPas.PressKeys(PAS);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ItemPasNombre' at Center.", repo.ApplicationUnderTest.ItemPasNombreInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.ItemPasNombre.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(14));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_Actualizar' at 44;7.", repo.ApplicationUnderTest.Btn_ActualizarInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.Btn_Actualizar.Click("44;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.NroCuenta' and assigning its value to variable 'NroCuenta'.", repo.ApplicationUnderTest.NroCuentaInfo, new RecordItemIndex(16));
            NroCuenta = repo.ApplicationUnderTest.NroCuenta.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "El número de cuenta es:", new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "User", NroCuenta, new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Validar_ResumenDelArchivoDeCuenta' at 117;11.", repo.ApplicationUnderTest.Validar_ResumenDelArchivoDeCuentaInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.Validar_ResumenDelArchivoDeCuenta.Click("117;11");
            Delay.Milliseconds(0);
            
            // **** Validación de cuenta creada exitosamente ****
            Report.Log(ReportLevel.Info, "Section", "**** Validación de cuenta creada exitosamente ****", new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Resumen del archivo de cuenta') on item 'ApplicationUnderTest.Validar_ResumenDelArchivoDeCuenta'.", repo.ApplicationUnderTest.Validar_ResumenDelArchivoDeCuentaInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Validar_ResumenDelArchivoDeCuentaInfo, "InnerText", "Resumen del archivo de cuenta");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(22));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
