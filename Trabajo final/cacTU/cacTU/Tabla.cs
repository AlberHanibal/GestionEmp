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
                    datos.venta((int) linea.Cells["Indice"].Value, (int)linea.Cells["Stock"].Value);
                }
            }
        }
    }
}
