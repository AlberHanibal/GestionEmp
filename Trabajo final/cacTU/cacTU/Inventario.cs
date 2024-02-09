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

        public Inventario()
        {
            InitializeComponent();
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

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(comboAtributo.SelectedItem.ToString());
            // mirar que no se pueda escribir en el combobox https://stackoverflow.com/questions/85702/how-can-i-make-a-combobox-non-editable-in-net
            if (comboAtributo.SelectedItem != null && cajaBusqueda.Text != "")
            {

                Console.WriteLine("en el if");
            }
                
            
            // hacer la busqueda, crear la lista y pasarsela a Tabla(lista)

        }
    }
}
