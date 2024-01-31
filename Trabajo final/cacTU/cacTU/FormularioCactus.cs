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
        private BD datos;

        public FormularioCactus(DataGridViewRow linea = null)
            
        {
            
            InitializeComponent();
            Inventario.cambiarMenuTop();
            datos = new BD();
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
            if (camposObligatorios())
            {
                if (linea == null)
                {
                    Cactus cactus = new Cactus(cajaEspecie.Text, cajaGenero.Text, cajaTribu.Text, 
                        (int)cajaStock.Value, 0, cajaNombreComun.Text, cajaDistribucion.Text);
                    datos.añadirCactus(cactus);
                }
                else
                {
                    // modificar cactus, coger el indice
                    Cactus cactus = new Cactus(cajaEspecie.Text, cajaGenero.Text, cajaTribu.Text,
                        (int)cajaStock.Value, (int) linea.Cells["Indice"].Value, cajaNombreComun.Text, cajaDistribucion.Text);
                    datos.modificarCactus(cactus);
                }

                this.Controls.Clear();
                this.Controls.Add(new Tabla());
                Inventario.cambiarMenuTop();
            } else
            {
                // mostrar error
            }

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Tabla());
            Inventario.cambiarMenuTop();
        }

        private Boolean camposObligatorios()
        {
            if (cajaEspecie.Text == "" || cajaGenero.Text == "" || cajaTribu.Text == "")
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
