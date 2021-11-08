﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Unidad4Lab2.Clases
{
    class ManejadorArchivo
    {
        protected DataTable misContactos;

        public ManejadorArchivo()
        {
            this.misContactos = this.getTabla();
        }
        public virtual DataTable getTabla()
        {
            return new DataTable();
        }

        public virtual void aplicaCambios()
        {

        }

        public void listar()
        {
            foreach (DataRow fila in this.misContactos.Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    foreach (DataColumn col in this.misContactos.Columns)
                    {
                        Console.WriteLine("{0}: {1}", col.ColumnName, fila[col]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public void nuevaFila()
        {
            DataRow fila = this.misContactos.NewRow();
            foreach (DataColumn col in this.misContactos.Columns)
            {
                Console.WriteLine("Ingrese {0}:", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
            this.misContactos.Rows.Add(fila);
        }

        public void editarFila()
        {
            Console.WriteLine("Ingrese el numero de fila a editar");
            int nroFila = int.Parse(Console.ReadLine());
            DataRow fila = this.misContactos.Rows[nroFila - 1];
            for (int nroCol = 1; nroCol < this.misContactos.Columns.Count; nroCol++)
            {
                DataColumn col = this.misContactos.Columns[nroCol];
                Console.WriteLine("Ingrese {0}:", col.ColumnName);
                fila[col] = Console.ReadLine();
            }
        }


        public void eliminarFila()
        {
            Console.WriteLine("Ingrese numero de fila a eliminar");
            int fila = int.Parse(Console.ReadLine());
            this.misContactos.Rows[fila - 1].Delete();
        }


    }
}
