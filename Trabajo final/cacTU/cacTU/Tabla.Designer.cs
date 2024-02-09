namespace cacTU
{
    partial class Tabla
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
            this.tablaCactus = new System.Windows.Forms.DataGridView();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tribu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distribucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreComun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Venta = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCactus)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaCactus
            // 
            this.tablaCactus.AllowUserToAddRows = false;
            this.tablaCactus.AllowUserToDeleteRows = false;
            this.tablaCactus.BackgroundColor = System.Drawing.Color.Beige;
            this.tablaCactus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCactus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaCactus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCactus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indice,
            this.Especie,
            this.Genero,
            this.Tribu,
            this.Distribucion,
            this.NombreComun,
            this.Stock,
            this.Modificar,
            this.Venta});
            this.tablaCactus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaCactus.Location = new System.Drawing.Point(0, 0);
            this.tablaCactus.Name = "tablaCactus";
            this.tablaCactus.ReadOnly = true;
            this.tablaCactus.Size = new System.Drawing.Size(939, 462);
            this.tablaCactus.TabIndex = 1;
            this.tablaCactus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCactus_CellClick);
            this.tablaCactus.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCactus_CellMouseEnter);
            this.tablaCactus.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaCactus_CellMouseLeave);
            this.tablaCactus.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.tablaCactus_PostRow);
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Indice";
            this.Indice.Name = "Indice";
            this.Indice.ReadOnly = true;
            this.Indice.Visible = false;
            // 
            // Especie
            // 
            this.Especie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Tribu
            // 
            this.Tribu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tribu.HeaderText = "Tribu";
            this.Tribu.Name = "Tribu";
            this.Tribu.ReadOnly = true;
            // 
            // Distribucion
            // 
            this.Distribucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Distribucion.HeaderText = "Distribución";
            this.Distribucion.Name = "Distribucion";
            this.Distribucion.ReadOnly = true;
            // 
            // NombreComun
            // 
            this.NombreComun.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreComun.HeaderText = "Nombre Común";
            this.NombreComun.Name = "NombreComun";
            this.NombreComun.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Venta
            // 
            this.Venta.HeaderText = "";
            this.Venta.Name = "Venta";
            this.Venta.ReadOnly = true;
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tablaCactus);
            this.Name = "Tabla";
            this.Size = new System.Drawing.Size(939, 462);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCactus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaCactus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tribu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distribucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreComun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Venta;
    }
}
