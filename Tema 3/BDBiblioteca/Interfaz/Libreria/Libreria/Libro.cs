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

        public Boolean camposRellenos()
        {
            return !cajaTitulo.Text.Equals("") && !cajaISBN.Text.Equals("") && !cajaAnno.Text.Equals("") && !cajaAutor.Text.Equals("")
                && !cajaEditorial.Text.Equals("") && !cajaGenero.Text.Equals("") && !cajaStock.Text.Equals("") && !cajaIdioma.Text.Equals("");
        }

        private void Libro_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AñadirLibro_Click(object sender, EventArgs e)
        {
            if (camposRellenos())
            {
                SqlCommand cmd = new SqlCommand("[biblio].[buscarAutorPorNombre]", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = cajaAutor.Text;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int idAutor = (int)dr.GetValue(0);
                    dr.Close();
                    cmd.Dispose();
                    cmd = new SqlCommand("[biblio].[añadirLibro]", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@titulo", SqlDbType.VarChar).Value = cajaTitulo.Text;
                    cmd.Parameters.Add("@ISBN", SqlDbType.VarChar).Value = cajaISBN.Text;
                    cmd.Parameters.Add("@anoPublicacion", SqlDbType.Int).Value = cajaAnno.Text;
                    cmd.Parameters.Add("@IDAutor", SqlDbType.Int).Value = idAutor;
                    cmd.Parameters.Add("@Editorial", SqlDbType.VarChar).Value = cajaEditorial.Text;
                    cmd.Parameters.Add("@Genero", SqlDbType.VarChar).Value = cajaGenero.Text;
                    cmd.Parameters.Add("@Stock", SqlDbType.Int).Value = cajaStock.Text;
                    cmd.Parameters.Add("@Idioma", SqlDbType.VarChar).Value = cajaIdioma.Text;
                    cmd.ExecuteNonQuery();
                } // no existe el autor

            }
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
            /*
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
            */
        }
        private void busquedaTitulo(object sender, EventArgs e)
        {
            listaLibros.Items.Clear();
            SqlCommand cmd = new SqlCommand("[biblio].[buscarLibroPorTitulo]", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = cajaBusquedaTitulo.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                
                tablaLibros.Rows.Add(dr.GetValue(dr.GetOrdinal("ID")), dr.GetValue(dr.GetOrdinal("Titulo")), dr.GetValue(dr.GetOrdinal("ISBN")), 
                    dr.GetValue(dr.GetOrdinal("Año Publicacion")), "Autor", dr.GetValue(dr.GetOrdinal("Editorial")), 
                    dr.GetValue(dr.GetOrdinal("Genero")), dr.GetValue(dr.GetOrdinal("Stock")), dr.GetValue(dr.GetOrdinal("Idioma")));
                //String linea = (String) dr.GetValue(dr.GetOrdinal("Titulo")) + " " + (String) dr.GetValue(dr.GetOrdinal("ISBN"));
                //listaLibros.Items.Add(linea);
                // habría que coger el nombre del autor con el id
            }
            dr.Close();
            cmd.Dispose();
        }

        private void tablaLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ModificarLibro_Click(object sender, EventArgs e)
        {
            DataGridViewRow linea = tablaLibros.SelectedRows[0];
            Console.WriteLine(linea.Cells[2].Value);
        }
    }
}
