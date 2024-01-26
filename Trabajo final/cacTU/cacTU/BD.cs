using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cacTU
{
    internal class BD
    {
        private string rutaArchivo;
        SLDocument archivo;
        // guardarme el índice último para usarlo para insertar por el final
        public BD()
        {
            archivo = new SLDocument();
            rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "cactus.xlsx";
            if (File.Exists(rutaArchivo))
            {
                Console.WriteLine("El archivo existe");
            } else
            {
                Console.WriteLine("El archivo no existe");
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Especie", typeof(string));
                tabla.Columns.Add("Género", typeof(string));
                tabla.Columns.Add("Tribu", typeof(string));
                tabla.Columns.Add("Nombre Común", typeof(string));
                tabla.Columns.Add("Distribución", typeof(string));
                tabla.Columns.Add("Stock", typeof(int));

                archivo.ImportDataTable(0, 0, tabla, true);
                archivo.SaveAs(rutaArchivo);
            }
            
        }

        public void añadirCactus (Cactus cactus)
        {
            DataTable tabla = new DataTable();
        }

        public void leerExcel ()
        {
            // mientras se lee ir haciendo una lista y devolverla luego

        }
    }
}
