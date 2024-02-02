namespace cacTU
{
    partial class FormularioCactus
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
            this.cajaEspecie = new System.Windows.Forms.TextBox();
            this.cajaGenero = new System.Windows.Forms.TextBox();
            this.cajaTribu = new System.Windows.Forms.TextBox();
            this.cajaNombreComun = new System.Windows.Forms.TextBox();
            this.cajaDistribucion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.cajaStock = new System.Windows.Forms.NumericUpDown();
            this.textoStock = new System.Windows.Forms.Label();
            this.textoDistribucion = new System.Windows.Forms.Label();
            this.textoNombreComun = new System.Windows.Forms.Label();
            this.TextoTribu = new System.Windows.Forms.Label();
            this.textoGenero = new System.Windows.Forms.Label();
            this.textoEspecie = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaStock)).BeginInit();
            this.SuspendLayout();
            // 
            // cajaEspecie
            // 
            this.cajaEspecie.Location = new System.Drawing.Point(151, 52);
            this.cajaEspecie.Name = "cajaEspecie";
            this.cajaEspecie.Size = new System.Drawing.Size(100, 22);
            this.cajaEspecie.TabIndex = 0;
            // 
            // cajaGenero
            // 
            this.cajaGenero.Location = new System.Drawing.Point(401, 52);
            this.cajaGenero.Name = "cajaGenero";
            this.cajaGenero.Size = new System.Drawing.Size(100, 22);
            this.cajaGenero.TabIndex = 1;
            this.cajaGenero.TextChanged += new System.EventHandler(this.campoEscrito);
            // 
            // cajaTribu
            // 
            this.cajaTribu.Location = new System.Drawing.Point(638, 52);
            this.cajaTribu.Name = "cajaTribu";
            this.cajaTribu.Size = new System.Drawing.Size(100, 22);
            this.cajaTribu.TabIndex = 2;
            this.cajaTribu.TextChanged += new System.EventHandler(this.campoEscrito);
            // 
            // cajaNombreComun
            // 
            this.cajaNombreComun.Location = new System.Drawing.Point(151, 176);
            this.cajaNombreComun.Name = "cajaNombreComun";
            this.cajaNombreComun.Size = new System.Drawing.Size(100, 22);
            this.cajaNombreComun.TabIndex = 3;
            // 
            // cajaDistribucion
            // 
            this.cajaDistribucion.Location = new System.Drawing.Point(401, 176);
            this.cajaDistribucion.Name = "cajaDistribucion";
            this.cajaDistribucion.Size = new System.Drawing.Size(100, 22);
            this.cajaDistribucion.TabIndex = 4;
            this.cajaDistribucion.TextChanged += new System.EventHandler(this.campoEscrito);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonCancelar);
            this.groupBox1.Controls.Add(this.botonGuardar);
            this.groupBox1.Controls.Add(this.cajaStock);
            this.groupBox1.Controls.Add(this.textoStock);
            this.groupBox1.Controls.Add(this.textoDistribucion);
            this.groupBox1.Controls.Add(this.textoNombreComun);
            this.groupBox1.Controls.Add(this.TextoTribu);
            this.groupBox1.Controls.Add(this.textoGenero);
            this.groupBox1.Controls.Add(this.textoEspecie);
            this.groupBox1.Controls.Add(this.cajaEspecie);
            this.groupBox1.Controls.Add(this.cajaGenero);
            this.groupBox1.Controls.Add(this.cajaNombreComun);
            this.groupBox1.Controls.Add(this.cajaDistribucion);
            this.groupBox1.Controls.Add(this.cajaTribu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(50, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 279);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(638, 239);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 14;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(746, 239);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 13;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // cajaStock
            // 
            this.cajaStock.Location = new System.Drawing.Point(638, 176);
            this.cajaStock.Name = "cajaStock";
            this.cajaStock.Size = new System.Drawing.Size(100, 22);
            this.cajaStock.TabIndex = 12;
            // 
            // textoStock
            // 
            this.textoStock.AutoSize = true;
            this.textoStock.Location = new System.Drawing.Point(574, 180);
            this.textoStock.Name = "textoStock";
            this.textoStock.Size = new System.Drawing.Size(41, 16);
            this.textoStock.TabIndex = 11;
            this.textoStock.Text = "Stock";
            // 
            // textoDistribucion
            // 
            this.textoDistribucion.AutoSize = true;
            this.textoDistribucion.Location = new System.Drawing.Point(302, 180);
            this.textoDistribucion.Name = "textoDistribucion";
            this.textoDistribucion.Size = new System.Drawing.Size(77, 16);
            this.textoDistribucion.TabIndex = 10;
            this.textoDistribucion.Text = "Distribución";
            // 
            // textoNombreComun
            // 
            this.textoNombreComun.AutoSize = true;
            this.textoNombreComun.Location = new System.Drawing.Point(34, 180);
            this.textoNombreComun.Name = "textoNombreComun";
            this.textoNombreComun.Size = new System.Drawing.Size(101, 16);
            this.textoNombreComun.TabIndex = 9;
            this.textoNombreComun.Text = "Nombre Común";
            // 
            // TextoTribu
            // 
            this.TextoTribu.AutoSize = true;
            this.TextoTribu.Location = new System.Drawing.Point(574, 55);
            this.TextoTribu.Name = "TextoTribu";
            this.TextoTribu.Size = new System.Drawing.Size(38, 16);
            this.TextoTribu.TabIndex = 8;
            this.TextoTribu.Text = "Tribu";
            // 
            // textoGenero
            // 
            this.textoGenero.AutoSize = true;
            this.textoGenero.Location = new System.Drawing.Point(327, 55);
            this.textoGenero.Name = "textoGenero";
            this.textoGenero.Size = new System.Drawing.Size(52, 16);
            this.textoGenero.TabIndex = 7;
            this.textoGenero.Text = "Género";
            // 
            // textoEspecie
            // 
            this.textoEspecie.AutoSize = true;
            this.textoEspecie.Location = new System.Drawing.Point(78, 55);
            this.textoEspecie.Name = "textoEspecie";
            this.textoEspecie.Size = new System.Drawing.Size(57, 16);
            this.textoEspecie.TabIndex = 6;
            this.textoEspecie.Text = "Especie";
            // 
            // FormularioCactus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FormularioCactus";
            this.Size = new System.Drawing.Size(939, 462);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cajaStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox cajaEspecie;
        private System.Windows.Forms.TextBox cajaGenero;
        private System.Windows.Forms.TextBox cajaTribu;
        private System.Windows.Forms.TextBox cajaNombreComun;
        private System.Windows.Forms.TextBox cajaDistribucion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.NumericUpDown cajaStock;
        private System.Windows.Forms.Label textoStock;
        private System.Windows.Forms.Label textoDistribucion;
        private System.Windows.Forms.Label textoNombreComun;
        private System.Windows.Forms.Label TextoTribu;
        private System.Windows.Forms.Label textoGenero;
        private System.Windows.Forms.Label textoEspecie;
        private System.Windows.Forms.Button botonCancelar;
    }
}
