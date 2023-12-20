using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            new Autor().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView tabla = sender as DataGridView;
            //Console.WriteLine(tabla.Rows.IndexOf);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lista = sender as ListBox;
            dataGridView1.Rows.Add(lista.SelectedItem);
            Console.WriteLine(lista.SelectedItem);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void libro_Click(object sender, EventArgs e)
        {

        }
    }
}
