using SpreadsheetLight;
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
    public partial class Inventario : Form
    {
        private static Panel menu;
        private BD datos;

        public Inventario()
        {
            InitializeComponent();
            datos = new BD();
            contenido.Controls.Add(new Tabla());
            menu = menuTop;
            
        }

        private void AñadirCactus_Click(object sender, EventArgs e)
        {
            contenido.Controls.Clear();
            contenido.Controls.Add(new FormularioCactus());
        }

        public static void cambiarMenuTop()
        {
            if (menu.Visible == true)
            {
                menu.Visible = false;
            } else
            {
                menu.Visible = true;
            }
        }

        private void busquedaCampo(object sender, EventArgs e)
        {
            if (comboAtributo.SelectedItem != null && cajaBusqueda.Text != "")
            {
                int campo = 0;
                switch (comboAtributo.SelectedItem.ToString())
                {
                    case "Especie":
                        campo = 1;
                        break;
                    case "Género":
                        campo = 2;
                        break;
                    case "Tribu":
                        campo = 3;
                        break;
                    case "Nombre Común":
                        campo = 4;
                        break;
                    case "Distribución":
                        campo = 5;
                        break;
                }
                if (campo != 0)
                {
                    List<Cactus> listaCactus = datos.busquedaCelda(cajaBusqueda.Text.ToLower(), campo);
                    contenido.Controls.Clear();
                    contenido.Controls.Add(new Tabla(listaCactus));
                }
            } else if (comboAtributo.SelectedItem != null && cajaBusqueda.Text == "")
            {
                contenido.Controls.Clear();
                contenido.Controls.Add(new Tabla());
            }
        }

        private void reiniciarInventario_Click(object sender, EventArgs e)
        {
            contenido.Controls.Clear();
            contenido.Controls.Add(new Tabla());
            cajaBusqueda.Text = "";
        }
    }
}
