﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using System.IO;

namespace Smoke.Emision
{
    public partial class EmisionPoliza
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void guardarNumPoliza()
        {
        	verificarDirectorio();
			string path = @"C:\TEMP\Polizas\polizas.csv";
			bool exist = File.Exists(path);
			
			string cabecera = "NumPoliza,NumCuenta" + System.Environment.NewLine;
			string datos = NumPolizaEmitida + "," + ValidateNroCuenta + System.Environment.NewLine;
		
			if(exist) {
				try {
					File.AppendAllText(path,datos);
					Report.Info("Info", "El archivo polizas.csv ya existía previamente");
					Report.Success("Info", "Los datos han sido guardados correctamente");
				} catch (Exception e) {
					Report.Failure("Fail", "Error al guardar los datos\r\nError: " + e);
					throw;
				}
			} else {
				try {
					Report.Info("Info", "Se creó el archivo polizas.csv");
					File.WriteAllText(path,cabecera);
					File.AppendAllText(path,datos);
					Report.Success("Info", "Los datos han sido guardados correctamente");
				} catch (Exception e) {
					Report.Failure("Fail", "Error al crear el archivo o guardar los datos\r\nError: " + e);
					throw;
				}
				
			}
        }
        
        public void verificarDirectorio(){
        	Report.Info("Info","Verificando la existencia del directorio destino");
			
        	if (!Directory.Exists(@"C:\TEMP\Polizas"))
			{
				Report.Info("Info","No se encontro el directorio, comienza la creacion del directorio...");
				Directory.CreateDirectory(@"C:\TEMP\Polizas");
				Report.Info("Info","Creacion del directorio finalizada.");
			}
			Report.Info("Info","Verificacion finalizada");
        }

        public void AprobacionBloqueo()
        {
            // TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            Report.Info("Info:","Esperando el Botón Detalle por 10s");
            if(repo.SURA_ContinueOnFail.btn_DetallesInfo.Exists(12000)){
            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA_ContinueOnFail.btn_Detalles' at Center.", repo.SURA_ContinueOnFail.btn_DetallesInfo, new RecordItemIndex(4));
	            repo.SURA_ContinueOnFail.btn_Detalles.Click();
	            
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA_ContinueOnFail.btn_AprobacionEspecial' at Center.", repo.SURA_ContinueOnFail.btn_AprobacionEspecialInfo, new RecordItemIndex(5));
	            repo.SURA_ContinueOnFail.btn_AprobacionEspecial.Click();
	            
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA_ContinueOnFail.bttn_AceptarCOF' at Center.", repo.SURA_ContinueOnFail.bttn_AceptarCOFInfo, new RecordItemIndex(6));
	            repo.SURA_ContinueOnFail.bttn_AceptarCOF.Click();
	            
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA_ContinueOnFail.bttn_Aceptar4' at Center.", repo.SURA_ContinueOnFail.bttn_Aceptar4Info, new RecordItemIndex(7));
	            repo.SURA_ContinueOnFail.bttn_Aceptar4.Click();
	           
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_EmitirPoliza' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_EmitirPolizaInfo, new RecordItemIndex(8));
	            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_EmitirPoliza.Click();
	            
	            
	            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Aceptar' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_AceptarInfo, new RecordItemIndex(9));
	            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Aceptar.Click();
	            
            }
        }

    }
}
