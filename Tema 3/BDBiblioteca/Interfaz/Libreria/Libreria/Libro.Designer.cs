namespace Libreria
{
    partial class Libro
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AñadirLibro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cajaStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cajaGenero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cajaIdioma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cajaEditorial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cajaAnno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cajaISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cajaAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cajaTitulo = new System.Windows.Forms.TextBox();
            this.listaLibros = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cajaBusquedaTitulo = new System.Windows.Forms.TextBox();
            this.BorrarLibro = new System.Windows.Forms.Button();
            this.ModificarLibro = new System.Windows.Forms.Button();
            this.tablaLibros = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AñoPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AñadirLibro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cajaStock);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cajaGenero);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cajaIdioma);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cajaEditorial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cajaAnno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cajaISBN);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cajaAutor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cajaTitulo);
            this.groupBox1.Location = new System.Drawing.Point(30, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NuevoLibro";
            // 
            // AñadirLibro
            // 
            this.AñadirLibro.Location = new System.Drawing.Point(735, 117);
            this.AñadirLibro.Name = "AñadirLibro";
            this.AñadirLibro.Size = new System.Drawing.Size(75, 23);
            this.AñadirLibro.TabIndex = 16;
            this.AñadirLibro.Text = "Añadir Libro";
            this.AñadirLibro.UseVisualStyleBackColor = true;
            this.AñadirLibro.Click += new System.EventHandler(this.AñadirLibro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Stock";
            // 
            // cajaStock
            // 
            this.cajaStock.Location = new System.Drawing.Point(469, 87);
            this.cajaStock.Name = "cajaStock";
            this.cajaStock.Size = new System.Drawing.Size(107, 20);
            this.cajaStock.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Género";
            // 
            // cajaGenero
            // 
            this.cajaGenero.Location = new System.Drawing.Point(245, 87);
            this.cajaGenero.Name = "cajaGenero";
            this.cajaGenero.Size = new System.Drawing.Size(107, 20);
            this.cajaGenero.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Idioma";
            // 
            // cajaIdioma
            // 
            this.cajaIdioma.Location = new System.Drawing.Point(650, 87);
            this.cajaIdioma.Name = "cajaIdioma";
            this.cajaIdioma.Size = new System.Drawing.Size(107, 20);
            this.cajaIdioma.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Editorial";
            // 
            // cajaEditorial
            // 
            this.cajaEditorial.Location = new System.Drawing.Point(73, 87);
            this.cajaEditorial.Name = "cajaEditorial";
            this.cajaEditorial.Size = new System.Drawing.Size(107, 20);
            this.cajaEditorial.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Año publicación";
            // 
            // cajaAnno
            // 
            this.cajaAnno.Location = new System.Drawing.Point(469, 32);
            this.cajaAnno.Name = "cajaAnno";
            this.cajaAnno.Size = new System.Drawing.Size(107, 20);
            this.cajaAnno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ISBN";
            // 
            // cajaISBN
            // 
            this.cajaISBN.Location = new System.Drawing.Point(245, 32);
            this.cajaISBN.Name = "cajaISBN";
            this.cajaISBN.Size = new System.Drawing.Size(107, 20);
            this.cajaISBN.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor";
            // 
            // cajaAutor
            // 
            this.cajaAutor.Location = new System.Drawing.Point(650, 32);
            this.cajaAutor.Name = "cajaAutor";
            this.cajaAutor.Size = new System.Drawing.Size(107, 20);
            this.cajaAutor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título";
            // 
            // cajaTitulo
            // 
            this.cajaTitulo.Location = new System.Drawing.Point(73, 32);
            this.cajaTitulo.Name = "cajaTitulo";
            this.cajaTitulo.Size = new System.Drawing.Size(107, 20);
            this.cajaTitulo.TabIndex = 0;
            // 
            // listaLibros
            // 
            this.listaLibros.HideSelection = false;
            this.listaLibros.Location = new System.Drawing.Point(30, 270);
            this.listaLibros.Name = "listaLibros";
            this.listaLibros.Size = new System.Drawing.Size(816, 36);
            this.listaLibros.TabIndex = 1;
            this.listaLibros.UseCompatibleStateImageBehavior = false;
            this.listaLibros.View = System.Windows.Forms.View.List;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cajaBusquedaTitulo);
            this.groupBox2.Controls.Add(this.BorrarLibro);
            this.groupBox2.Controls.Add(this.ModificarLibro);
            this.groupBox2.Location = new System.Drawing.Point(30, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(816, 83);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Buscar por Título";
            // 
            // cajaBusquedaTitulo
            // 
            this.cajaBusquedaTitulo.Location = new System.Drawing.Point(35, 56);
            this.cajaBusquedaTitulo.Name = "cajaBusquedaTitulo";
            this.cajaBusquedaTitulo.Size = new System.Drawing.Size(100, 20);
            this.cajaBusquedaTitulo.TabIndex = 2;
            this.cajaBusquedaTitulo.TextChanged += new System.EventHandler(this.busquedaTitulo);
            // 
            // BorrarLibro
            // 
            this.BorrarLibro.Location = new System.Drawing.Point(345, 54);
            this.BorrarLibro.Name = "BorrarLibro";
            this.BorrarLibro.Size = new System.Drawing.Size(75, 23);
            this.BorrarLibro.TabIndex = 1;
            this.BorrarLibro.Text = "Borrar";
            this.BorrarLibro.UseVisualStyleBackColor = true;
            // 
            // ModificarLibro
            // 
            this.ModificarLibro.Location = new System.Drawing.Point(200, 54);
            this.ModificarLibro.Name = "ModificarLibro";
            this.ModificarLibro.Size = new System.Drawing.Size(75, 23);
            this.ModificarLibro.TabIndex = 0;
            this.ModificarLibro.Text = "Modificar";
            this.ModificarLibro.UseVisualStyleBackColor = true;
            this.ModificarLibro.Click += new System.EventHandler(this.ModificarLibro_Click);
            // 
            // tablaLibros
            // 
            this.tablaLibros.AllowUserToAddRows = false;
            this.tablaLibros.AllowUserToDeleteRows = false;
            this.tablaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Titulo,
            this.ISBN,
            this.AñoPublicacion,
            this.Autor,
            this.Editorial,
            this.Genero,
            this.Stock,
            this.Idioma});
            this.tablaLibros.Location = new System.Drawing.Point(30, 312);
            this.tablaLibros.Name = "tablaLibros";
            this.tablaLibros.ReadOnly = true;
            this.tablaLibros.Size = new System.Drawing.Size(816, 118);
            this.tablaLibros.TabIndex = 3;
            this.tablaLibros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaLibros_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // AñoPublicacion
            // 
            this.AñoPublicacion.HeaderText = "Año Publicación";
            this.AñoPublicacion.Name = "AñoPublicacion";
            this.AñoPublicacion.ReadOnly = true;
            this.AñoPublicacion.Width = 70;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "Editorial";
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 80;
            // 
            // Idioma
            // 
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            this.Idioma.ReadOnly = true;
            // 
            // Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablaLibros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listaLibros);
            this.Controls.Add(this.groupBox1);
            this.Name = "Libro";
            this.Size = new System.Drawing.Size(885, 456);
            this.Load += new System.EventHandler(this.Libro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajaAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cajaStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cajaGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cajaIdioma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cajaEditorial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cajaAnno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cajaISBN;
        private System.Windows.Forms.Button AñadirLibro;
        private System.Windows.Forms.ListView listaLibros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cajaBusquedaTitulo;
        private System.Windows.Forms.Button BorrarLibro;
        private System.Windows.Forms.Button ModificarLibro;
        private System.Windows.Forms.DataGridView tablaLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn AñoPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
    }
}
