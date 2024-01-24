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
        public Tabla()
        {
            InitializeComponent();
            // leer excel (sino existe crearlo) y mostrar el inventario
            tablaCactus.Rows.Add(0, "asdsad", "qweqwe", "yutyut", "españa", "con pinchos", 10, "Modificar", "Venta");
            tablaCactus.Rows.Add(1, "aasdsdsad", "qweqweqwe", "yutytrut", "españa2", "con pinchos2", 10, "Modificar", "Venta");
        }

        private void tablaCactus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // peta si se clica en un header
            DataGridViewRow linea = tablaCactus.Rows[e.RowIndex];
            if (e.ColumnIndex == linea.Cells["Modificar"].ColumnIndex)
            {
                this.Controls.Clear();
                this.Controls.Add(new FormularioCactus(linea));
            } else if (e.ColumnIndex == linea.Cells["Venta"].ColumnIndex)
            {
                if ((int) linea.Cells["Stock"].Value > 0)
                {
                    linea.Cells["Stock"].Value = (int) linea.Cells["Stock"].Value - 1;
                }
            }
        }
    }
}
