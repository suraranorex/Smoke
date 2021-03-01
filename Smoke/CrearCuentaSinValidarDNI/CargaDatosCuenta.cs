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
    ///The CargaDatosCuenta recording.
    /// </summary>
    [TestModule("ae8d76b8-ca8d-489d-9235-d22edfe1e8c5", ModuleType.Recording, 1)]
    public partial class CargaDatosCuenta : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Smoke.SmokeRepository repository.
        /// </summary>
        public static global::Smoke.SmokeRepository repo = global::Smoke.SmokeRepository.Instance;

        static CargaDatosCuenta instance = new CargaDatosCuenta();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CargaDatosCuenta()
        {
            Documento = "24566780";
            Provincia = "CATAMARCA";
            Localidad = "FIAMBALA";
            Calle = "Jujuy";
            NumeroCalle = "200";
            FechaNacimiento = "12/12/1980";
            correoprincipal = "aseguradosgw@gmail.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CargaDatosCuenta Instance
        {
            get { return instance; }
        }

#region Variables

        string _Documento;

        /// <summary>
        /// Gets or sets the value of variable Documento.
        /// </summary>
        [TestVariable("a2f8e0c0-d527-47bb-9280-4d906442c16f")]
        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }

        string _Calle;

        /// <summary>
        /// Gets or sets the value of variable Calle.
        /// </summary>
        [TestVariable("dde27135-7cd8-4559-9595-fca2a3999c9c")]
        public string Calle
        {
            get { return _Calle; }
            set { _Calle = value; }
        }

        string _NumeroCalle;

        /// <summary>
        /// Gets or sets the value of variable NumeroCalle.
        /// </summary>
        [TestVariable("8ef3b852-64c8-4518-9328-95e257f5bb52")]
        public string NumeroCalle
        {
            get { return _NumeroCalle; }
            set { _NumeroCalle = value; }
        }

        string _FechaNacimiento;

        /// <summary>
        /// Gets or sets the value of variable FechaNacimiento.
        /// </summary>
        [TestVariable("e1da83f3-32d6-4f5b-a1df-244609b2f689")]
        public string FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        string _correoprincipal;

        /// <summary>
        /// Gets or sets the value of variable correoprincipal.
        /// </summary>
        [TestVariable("269aaa38-23b6-4e4c-8135-bbb4c4ff9ddd")]
        public string correoprincipal
        {
            get { return _correoprincipal; }
            set { _correoprincipal = value; }
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
        /// Gets or sets the value of variable Provincia.
        /// </summary>
        [TestVariable("d59d41b7-d196-438c-b318-6009ed1068fa")]
        public string Provincia
        {
            get { return repo.Provincia; }
            set { repo.Provincia = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Localidad.
        /// </summary>
        [TestVariable("ac4fe456-5c0e-4a41-9ad7-e03a64d64e1c")]
        public string Localidad
        {
            get { return repo.Localidad; }
            set { repo.Localidad = value; }
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

            // **** Cargar Datos de la Cuenta ****
            Report.Log(ReportLevel.Info, "Section", "**** Cargar Datos de la Cuenta ****", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Btn_AGregarDocumento' at 56;12.", repo.ApplicationUnderTest.Btn_AGregarDocumentoInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Btn_AGregarDocumento.Click("56;12");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.Copy_of_TipoDocumento1' at Center.", repo.ApplicationUnderTest.Copy_of_TipoDocumento1Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Copy_of_TipoDocumento1.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Copy_of_TipoDocumento1' at 105;16.", repo.ApplicationUnderTest.Copy_of_TipoDocumento1Info, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Copy_of_TipoDocumento1.Click("105;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'ApplicationUnderTest.Copy_of_Copy_of_TipoDocumento1'", repo.ApplicationUnderTest.Copy_of_Copy_of_TipoDocumento1Info, new ActionTimeout(45000), new RecordItemIndex(4));
            repo.ApplicationUnderTest.Copy_of_Copy_of_TipoDocumento1Info.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Select_Tipo_Doc' at 29;13.", repo.ApplicationUnderTest.Select_Tipo_DocInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.Select_Tipo_Doc.Click("29;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.bl_CrearCuenta' at Center.", repo.ApplicationUnderTest.bl_CrearCuentaInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.bl_CrearCuenta.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'ApplicationUnderTest.XTableLayout.Copy_of_TipoDocumento'", repo.ApplicationUnderTest.XTableLayout.Copy_of_TipoDocumentoInfo, new ActionTimeout(45000), new RecordItemIndex(7));
            //repo.ApplicationUnderTest.XTableLayout.Copy_of_TipoDocumentoInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(8));
            Delay.Duration(6000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.Txt_NumeroDoc' at Center.", repo.ApplicationUnderTest.XTableLayout.Txt_NumeroDocInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.XTableLayout.Txt_NumeroDoc.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Documento' with focus on 'ApplicationUnderTest.XTableLayout.Txt_NumeroDoc'.", repo.ApplicationUnderTest.XTableLayout.Txt_NumeroDocInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.XTableLayout.Txt_NumeroDoc.EnsureVisible();
            Keyboard.Press(Documento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Documento, new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.Lbl_CondicionFiscal' at Center.", repo.ApplicationUnderTest.XTableLayout.Lbl_CondicionFiscalInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.XTableLayout.Lbl_CondicionFiscal.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'ApplicationUnderTest.Cbo_CondicFiscal'", repo.ApplicationUnderTest.Cbo_CondicFiscalInfo, new ActionTimeout(40000), new RecordItemIndex(13));
            repo.ApplicationUnderTest.Cbo_CondicFiscalInfo.WaitForExists(40000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FechaNacimiento' with focus on 'ApplicationUnderTest.txt_Fecha_Nacimiento'.", repo.ApplicationUnderTest.txt_Fecha_NacimientoInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.txt_Fecha_Nacimiento.PressKeys(FechaNacimiento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.Lbl_CondicionFiscal' at Center.", repo.ApplicationUnderTest.XTableLayout.Lbl_CondicionFiscalInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.XTableLayout.Lbl_CondicionFiscal.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.Copy_of_txt_Fecha_Nacimiento'", repo.ApplicationUnderTest.Copy_of_txt_Fecha_NacimientoInfo, new ActionTimeout(30000), new RecordItemIndex(16));
            repo.ApplicationUnderTest.Copy_of_txt_Fecha_NacimientoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.txt_CorreoPrincipal' at Center.", repo.ApplicationUnderTest.XTableLayout.txt_CorreoPrincipalInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.XTableLayout.txt_CorreoPrincipal.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$correoprincipal' with focus on 'ApplicationUnderTest.XTableLayout.txt_CorreoPrincipal'.", repo.ApplicationUnderTest.XTableLayout.txt_CorreoPrincipalInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.XTableLayout.txt_CorreoPrincipal.PressKeys(correoprincipal);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.lbl_Email' at Center.", repo.ApplicationUnderTest.XTableLayout.lbl_EmailInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.XTableLayout.lbl_Email.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.XTableLayout.Copy_of_txt_CorreoPrincipal'", repo.ApplicationUnderTest.XTableLayout.Copy_of_txt_CorreoPrincipalInfo, new ActionTimeout(30000), new RecordItemIndex(20));
            repo.ApplicationUnderTest.XTableLayout.Copy_of_txt_CorreoPrincipalInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.Click_Provincia' at 11;14.", repo.ApplicationUnderTest.XTableLayout.Click_ProvinciaInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.XTableLayout.Click_Provincia.Click("11;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.PrimerItemProvincia'", repo.ApplicationUnderTest.PrimerItemProvinciaInfo, new ActionTimeout(30000), new RecordItemIndex(22));
            repo.ApplicationUnderTest.PrimerItemProvinciaInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Provincia' with focus on 'ApplicationUnderTest.txtProvincia'.", repo.ApplicationUnderTest.txtProvinciaInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.txtProvincia.PressKeys(Provincia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ItemProvincia' at Center.", repo.ApplicationUnderTest.ItemProvinciaInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.ItemProvincia.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.Copy_of_txtProvincia'", repo.ApplicationUnderTest.Copy_of_txtProvinciaInfo, new ActionTimeout(30000), new RecordItemIndex(25));
            repo.ApplicationUnderTest.Copy_of_txtProvinciaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.Click_Localidad' at Center.", repo.ApplicationUnderTest.XTableLayout.Click_LocalidadInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.XTableLayout.Click_Localidad.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.PrimerItemLocalidad'", repo.ApplicationUnderTest.PrimerItemLocalidadInfo, new ActionTimeout(30000), new RecordItemIndex(27));
            repo.ApplicationUnderTest.PrimerItemLocalidadInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'ApplicationUnderTest.XTableLayout.Click_Localidad'.", repo.ApplicationUnderTest.XTableLayout.Click_LocalidadInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.XTableLayout.Click_Localidad.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Localidad' with focus on 'ApplicationUnderTest.XTableLayout.Click_Localidad'.", repo.ApplicationUnderTest.XTableLayout.Click_LocalidadInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.XTableLayout.Click_Localidad.PressKeys(Localidad);
            Delay.Milliseconds(20);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ItemLocalidad' at Center.", repo.ApplicationUnderTest.ItemLocalidadInfo, new RecordItemIndex(30));
            //repo.ApplicationUnderTest.ItemLocalidad.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to not exist. Associated repository item: 'ApplicationUnderTest.XTableLayout.Copy_of_Click_Localidad'", repo.ApplicationUnderTest.XTableLayout.Copy_of_Click_LocalidadInfo, new ActionTimeout(50000), new RecordItemIndex(31));
            repo.ApplicationUnderTest.XTableLayout.Copy_of_Click_LocalidadInfo.WaitForNotExists(50000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lbl_Direccion' at Center.", repo.ApplicationUnderTest.lbl_DireccionInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.lbl_Direccion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.txt_Calle' at Center.", repo.ApplicationUnderTest.XTableLayout.txt_CalleInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.XTableLayout.txt_Calle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Calle' with focus on 'ApplicationUnderTest.XTableLayout.txt_Calle'.", repo.ApplicationUnderTest.XTableLayout.txt_CalleInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.XTableLayout.txt_Calle.PressKeys(Calle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lbl_Direccion' at Center.", repo.ApplicationUnderTest.lbl_DireccionInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.lbl_Direccion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to not exist. Associated repository item: 'ApplicationUnderTest.XTableLayout.txt_Calle_Espera'", repo.ApplicationUnderTest.XTableLayout.txt_Calle_EsperaInfo, new ActionTimeout(50000), new RecordItemIndex(36));
            repo.ApplicationUnderTest.XTableLayout.txt_Calle_EsperaInfo.WaitForNotExists(50000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.txt_Numero' at Center.", repo.ApplicationUnderTest.XTableLayout.txt_NumeroInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.XTableLayout.txt_Numero.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumeroCalle' with focus on 'ApplicationUnderTest.XTableLayout.txt_Numero'.", repo.ApplicationUnderTest.XTableLayout.txt_NumeroInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.XTableLayout.txt_Numero.EnsureVisible();
            Keyboard.Press(NumeroCalle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lbl_Direccion' at Center.", repo.ApplicationUnderTest.lbl_DireccionInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.lbl_Direccion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to not exist. Associated repository item: 'ApplicationUnderTest.XTableLayout.Copy_of_txt_Numero'", repo.ApplicationUnderTest.XTableLayout.Copy_of_txt_NumeroInfo, new ActionTimeout(50000), new RecordItemIndex(40));
            repo.ApplicationUnderTest.XTableLayout.Copy_of_txt_NumeroInfo.WaitForNotExists(50000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.Btn_ValidarDireccion' at Center.", repo.ApplicationUnderTest.XTableLayout.Btn_ValidarDireccionInfo, new RecordItemIndex(41));
            repo.ApplicationUnderTest.XTableLayout.Btn_ValidarDireccion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 8s.", new RecordItemIndex(42));
            Delay.Duration(8000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.ClickFlechaBuscaGrupo2' at CenterRight.", repo.ApplicationUnderTest.XTableLayout.ClickFlechaBuscaGrupo2Info, new RecordItemIndex(43));
            repo.ApplicationUnderTest.XTableLayout.ClickFlechaBuscaGrupo2.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BuscarGrupo' at Center.", repo.ApplicationUnderTest.BuscarGrupoInfo, new RecordItemIndex(44));
            repo.ApplicationUnderTest.BuscarGrupo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Validar_BuscarGrupos' at 112;14.", repo.ApplicationUnderTest.Validar_BuscarGruposInfo, new RecordItemIndex(45));
            repo.ApplicationUnderTest.Validar_BuscarGrupos.Click("112;14");
            Delay.Milliseconds(0);
            
            // **** Validación de Carga de Datos de la Cuenta exitoso ****
            Report.Log(ReportLevel.Info, "Section", "**** Validación de Carga de Datos de la Cuenta exitoso ****", new RecordItemIndex(46));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Buscar grupos') on item 'ApplicationUnderTest.Validar_BuscarGrupos'.", repo.ApplicationUnderTest.Validar_BuscarGruposInfo, new RecordItemIndex(47));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Validar_BuscarGruposInfo, "InnerText", "Buscar grupos");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
