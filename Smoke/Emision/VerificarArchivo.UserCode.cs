﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////
using System.IO;
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

namespace Smoke.Emision
{
    public partial class VerificarArchivo
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }


        public void VerificarArchivoCSV(string archivoSalida)
        {
            // TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            verificarDirectorio();
            string path = @"C:\TEMP\Polizas\Smoke\polizas.csv";
			bool exist = File.Exists(path);
			
			string cabecera = "NumPoliza,NumCuenta" + System.Environment.NewLine;
			
			if(exist) {
				try {
					Report.Info("Info", "El archivo polizas.csv ya existía previamente");
	
				} catch (Exception e) {
					Report.Failure("Fail", "Error al validar directorio\r\nError: " + e);
					throw;
				}
			} else {
				try {
					Report.Info("Info", "El archivo polizas.csv NO existía previamente");
					Report.Info("Info", "Se creó el archivo polizas.csv");
					File.WriteAllText(path,cabecera);
					Report.Success("Info", "El archivo polizas.csv se a creado correctamente");
					
				} catch (Exception e) {
					Report.Failure("Fail", "Error al crear el archivo\r\nError: " + e);
					throw;
				}
				
			}
            
        }
        
        public void verificarDirectorio(){
        	Report.Info("Info","Verificando la existencia del directorio destino");
			
        	if (!Directory.Exists(@"C:\TEMP\Smoke\Polizas"))
			{
				Report.Info("Info","No se encontro el directorio, comienza la creacion del directorio...");
				Directory.CreateDirectory(@"C:\TEMP\Smoke\Polizas");
				Report.Info("Info","Creacion del directorio finalizada.");
			}
			Report.Info("Info","Verificacion finalizada");
        }

    }
}
