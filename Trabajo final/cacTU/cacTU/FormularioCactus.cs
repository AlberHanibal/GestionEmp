using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cacTU
{
    public partial class FormularioCactus : UserControl
    {

        private DataGridViewRow linea = null;
        private BD datos;
        private List<Cactus> listaCompleta;

        public FormularioCactus(DataGridViewRow linea = null)
            
        {
            
            InitializeComponent();
            Inventario.cambiarMenuTop();
            datos = new BD();
            listaCompleta = datos.leerExcel();
            if (linea != null)
            {
                this.linea = linea;
                cajaEspecie.Text = (string) linea.Cells["Especie"].Value;
                cajaGenero.Text = (string) linea.Cells["Genero"].Value;
                cajaTribu.Text = (string) linea.Cells["Tribu"].Value;
                cajaDistribucion.Text = (string) linea.Cells["NombreComun"].Value;
                cajaNombreComun.Text = (string) linea.Cells["Distribucion"].Value;
                cajaStock.Value = (int) linea.Cells["Stock"].Value;
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (camposObligatorios())
            {
                if (linea == null)
                {
                    Cactus cactus = new Cactus(cajaEspecie.Text, cajaGenero.Text, cajaTribu.Text, 
                        (int)cajaStock.Value, 0, cajaDistribucion.Text, cajaNombreComun.Text);
                    datos.añadirCactus(cactus);
                }
                else
                {
                    // modificar cactus, coger el indice
                    Cactus cactus = new Cactus(cajaEspecie.Text, cajaGenero.Text, cajaTribu.Text,
                        (int)cajaStock.Value, (int) linea.Cells["Indice"].Value, cajaDistribucion.Text, cajaNombreComun.Text);
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

        private void campoEscrito(object sender, EventArgs e)
        {
            TextBox campo = sender as TextBox;
            if (!campo.Text.Equals(""))
            {
                // formato de los TextBox caja-atributoClase
                String nombreCampo = campo.Name.Substring(4);
                List<String> listaParaAutoCompletar = listaAutocompletar(listaCompleta, nombreCampo, campo.Text);

                campo.AutoCompleteMode = AutoCompleteMode.Suggest;
                AutoCompleteStringCollection accl = new AutoCompleteStringCollection();
                accl.AddRange(listaParaAutoCompletar.ToArray());
                campo.AutoCompleteCustomSource = accl;
                campo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                /*
                campo.AutoCompleteMode = AutoCompleteMode.Suggest;
                AutoCompleteStringCollection accl = new AutoCompleteStringCollection();
                String[] cosas = { "hola", "qwe", "kjolsadkasd" };
                accl.AddRange(cosas);
                campo.AutoCompleteCustomSource = accl;
                campo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                */
            }

        }

        private List<String> listaAutocompletar(List<Cactus> listaCompleta, String nombreCampo, String texto)
        {
            List<String> lista = new List<String>();
            string pattern = @"^" + texto + "\\w*";
            string input = "";
            Match m;
            foreach (Cactus cactus in listaCompleta)
            {
                if (nombreCampo.Equals("Genero"))
                {
                    input = cactus.getGenero();
                } else if (nombreCampo.Equals("Tribu")) {
                    input = cactus.getTribu();
                } else if (nombreCampo.Equals("Distribucion")) {
                    input = cactus.getDistribucion();
                }
                m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                if (m.Success)
                {
                    if (!lista.Contains(texto))
                    {
                        lista.Add(input);
                    }
                }
            }
            return lista;
        }
    }
}
