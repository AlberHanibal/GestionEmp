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
    }
}
