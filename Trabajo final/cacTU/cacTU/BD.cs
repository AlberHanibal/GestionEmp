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
        // guardarme el índice último para usarlo para insertar por el final
        private int ultimaFila;
        public BD()
        {
            SLDocument archivo = new SLDocument();
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

                archivo.ImportDataTable(1, 1, tabla, true);
                archivo.SaveAs(rutaArchivo);
            }
        }

        public void añadirCactus (Cactus cactus)
        {
            // para saber cual es el último
            leerExcel();

            SLDocument archivo = new SLDocument(rutaArchivo);
            archivo.InsertRow(ultimaFila + 1, 1);
            archivo.SetCellValue(ultimaFila + 1, 1, cactus.getEspecie());
            archivo.SetCellValue(ultimaFila + 1, 2, cactus.getGenero());
            archivo.SetCellValue(ultimaFila + 1, 3, cactus.getTribu());
            archivo.SetCellValue(ultimaFila + 1, 4, cactus.getNombreComun());
            archivo.SetCellValue(ultimaFila + 1, 5, cactus.getDistribucion());
            archivo.SetCellValue(ultimaFila + 1, 6, cactus.getStock());
            archivo.SaveAs(rutaArchivo);
        }

        public List<Cactus> leerExcel ()
        {
            SLDocument archivo = new SLDocument(rutaArchivo);
            int ind = 2;
            List<Cactus> listaCactus = new List<Cactus>();
            Cactus cactus;
            while (! string.IsNullOrEmpty(archivo.GetCellValueAsString(ind, 1))) {
                cactus = new Cactus(archivo.GetCellValueAsString(ind, 1), archivo.GetCellValueAsString(ind, 2), 
                    archivo.GetCellValueAsString(ind, 3), archivo.GetCellValueAsInt32(ind, 6), ind ,
                    archivo.GetCellValueAsString(ind, 4), archivo.GetCellValueAsString(ind, 5));
                listaCactus.Add(cactus);
                ind++;
            }
            ultimaFila = listaCactus.Count + 1;
            return listaCactus;
        }

        public void modificarCactus(Cactus cactus)
        {
            SLDocument archivo = new SLDocument(rutaArchivo);
            archivo.SetCellValue(cactus.getIndice(), 1, cactus.getEspecie());
            archivo.SetCellValue(cactus.getIndice(), 2, cactus.getGenero());
            archivo.SetCellValue(cactus.getIndice(), 3, cactus.getTribu());
            archivo.SetCellValue(cactus.getIndice(), 4, cactus.getNombreComun());
            archivo.SetCellValue(cactus.getIndice(), 5, cactus.getDistribucion());
            archivo.SetCellValue(cactus.getIndice(), 6, cactus.getStock());
            archivo.SaveAs(rutaArchivo);
        }

        public void venta(int indice, int stock)
        {
            if (stock > 0)
            {
                SLDocument archivo = new SLDocument(rutaArchivo);
                archivo.SetCellValue(indice, 6, stock - 1);
                archivo.SaveAs(rutaArchivo);
            }
        }
    }
}
