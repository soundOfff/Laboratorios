using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace Unidad4Lab2.Clases
{
    class ManejadorArchivoXml
    {
        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
        Data Source=C:\Proyectos\Unidades\Unidad 04\Lab02\Lab02\bin\Debug;" +
        "Extended Properties='text;HDR=Yes;FMT=Delimited'";
        public string ConnectionString { get
            {
                return connectionString;
            }
        }



    }
}
