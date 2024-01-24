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
    public partial class FormularioCactus : UserControl
    {

        private DataGridViewRow linea = null;

        public FormularioCactus(DataGridViewRow linea = null)
            
        {
            
            InitializeComponent();
            if (linea != null)
            {
                this.linea = linea;
                cajaEspecie.Text = (string) linea.Cells["Especie"].Value;
                cajaGenero.Text = (string) linea.Cells["Genero"].Value;
                cajaTribu.Text = (string) linea.Cells["Tribu"].Value;
                cajaNombreComun.Text = (string) linea.Cells["NombreComun"].Value;
                cajaDistribucion.Text = (string) linea.Cells["Distribucion"].Value;
                cajaStock.Value = (int) linea.Cells["Stock"].Value;
            }
        }

        private void FormularioCactus_Load(object sender, EventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (linea == null)
            {
                // añadir cactus
            } else
            {
                // modificar cactus, coger el indice
            }

            // si sale bien a Tabla()
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Tabla());
        }
    }
}
