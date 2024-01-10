using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Libro : UserControl
    {
        SqlConnection conexion;
        public Libro()
        {
            InitializeComponent();
            conexion = new SqlConnection(@"Data Source = C13-PC16\SQLEXPRESS01; Initial Catalog = LIBRERIA; User ID = librero; Password = librero");
            conexion.Open();
        }

        private void Libro_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AñadirLibro_Click(object sender, EventArgs e)
        {
            /*
            SqlCommand cmd = new SqlCommand("select * from Libros", conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr.GetValue(1));
            }
            dr.Close();
            cmd.Dispose();
            */
            SqlCommand cmd = new SqlCommand("[biblio].[buscarLibroPorTitulo]", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = cajaTitulo.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr.GetValue(1));
            }
            dr.Close();
            cmd.Dispose();
        }
    }
}
