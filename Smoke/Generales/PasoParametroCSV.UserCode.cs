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

namespace Smoke.Generales
{
    public partial class PasoParametroCSV
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void PasaParametroCSV()
        {
            // TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
            
            //-- Para validar la existencia del parametro usamos:
            if (TestSuite.Current.Parameters.ContainsKey("NroCuenta"))
            {
            	//Leer valor:
            	//TestSuite.Current.Parameters.TryGetValue(nombreParametro, out aux);
            	//Introducion valor:
            	
            	Report.Info("Info","Sí Existe");
            	TestSuite.Current.Parameters["NroCuenta"]=NroCuenta_CSV;
            	//TestSuite.Current.CurrentTestContainer.Parameters["NroCuenta"]=NroCuenta_CSV;
            }
            else{
            	Report.Info("Info:","No existe");
            
            }
        }

    }
}
