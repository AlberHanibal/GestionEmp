using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cacTU
{
    public partial class Tabla : UserControl
    {
        private BD datos;
        private Color colorImpar = Color.FromArgb(189, 217, 117);
        private Color colorImparSelec = Color.FromArgb(165, 201, 71);
        private Color colorPar = Color.FromArgb(147, 227, 104);
        private Color colorParSelec = Color.FromArgb(107, 196, 59);
        private string ultimaFila;
        public Tabla()
        {
            InitializeComponent();
            datos = new BD();
            List<Cactus> listaCactus = datos.leerExcel();
            foreach (Cactus cactus in listaCactus)
            {
                tablaCactus.Rows.Add(cactus.getIndice(), cactus.getEspecie(), cactus.getGenero(),
                    cactus.getTribu(), cactus.getDistribucion(), cactus.getNombreComun(), cactus.getStock(), "Modificar", "Venta");
            }
        }

        private void tablaCactus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //  si se clica en un header nada
            if (e.RowIndex !=  - 1)
            {
                DataGridViewRow linea = tablaCactus.Rows[e.RowIndex];
                if (e.ColumnIndex == linea.Cells["Modificar"].ColumnIndex)
                {
                    this.Controls.Clear();
                    this.Controls.Add(new FormularioCactus(linea));
                }
                else if (e.ColumnIndex == linea.Cells["Venta"].ColumnIndex)
                {
                    if ((int)linea.Cells["Stock"].Value > 0)
                    {
                        linea.Cells["Stock"].Value = (int)linea.Cells["Stock"].Value - 1;
                        datos.venta((int)linea.Cells["Indice"].Value, (int)linea.Cells["Stock"].Value);
                    }
                }
            }
        }

        private void tablaCactus_PostRow(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewRowCollection lineas = tablaCactus.Rows;
            foreach (DataGridViewRow row in lineas)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = colorPar;
                } else
                {
                    row.DefaultCellStyle.BackColor = colorImpar;
                }
            }
        }
        private void tablaCactus_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCactus.Rows.Count != 0 && e.RowIndex != -1)
            {
                ultimaFila = e.RowIndex % 2 == 0 ? "par" : "impar";
                DataGridViewCellCollection celdas = tablaCactus.Rows[e.RowIndex].Cells;
                foreach (DataGridViewCell cell in celdas)
                {
                    cell.Style.BackColor = e.RowIndex % 2 == 0 ? colorParSelec : colorImparSelec;
                }
            }
        }

        private void tablaCactus_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCactus.Rows.Count != 0 && e.RowIndex != - 1)
            {
                DataGridViewCellCollection celdas = tablaCactus.Rows[e.RowIndex].Cells;
                Color colorAntiguo = ultimaFila.Equals("par") ? colorPar : colorImpar;
                foreach (DataGridViewCell cell in celdas)
                {
                    cell.Style.BackColor = colorAntiguo;
                }
            }
        }

        
    }
}
