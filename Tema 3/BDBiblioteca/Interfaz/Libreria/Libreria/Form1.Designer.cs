namespace Libreria
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.autor = new System.Windows.Forms.Button();
            this.libro = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grupoBotones = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(30, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "sdfsdfsdf",
            "sdf",
            "sd",
            "fs",
            "dfs",
            "df",
            "sd",
            "fs",
            "dfs",
            "df"});
            this.listBox1.Location = new System.Drawing.Point(30, 340);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(576, 108);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, -3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.autor);
            this.splitContainer1.Panel1.Controls.Add(this.libro);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(802, 458);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 3;
            // 
            // autor
            // 
            this.autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autor.Location = new System.Drawing.Point(3, 93);
            this.autor.Name = "autor";
            this.autor.Size = new System.Drawing.Size(140, 37);
            this.autor.TabIndex = 1;
            this.autor.Text = "Autor";
            this.autor.UseVisualStyleBackColor = true;
            // 
            // libro
            // 
            this.libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libro.Location = new System.Drawing.Point(3, 15);
            this.libro.Name = "libro";
            this.libro.Size = new System.Drawing.Size(140, 37);
            this.libro.TabIndex = 0;
            this.libro.Text = "Libro";
            this.libro.UseVisualStyleBackColor = true;
            this.libro.Click += new System.EventHandler(this.libro_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grupoBotones);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 451);
            this.panel1.TabIndex = 3;
            // 
            // grupoBotones
            // 
            this.grupoBotones.Location = new System.Drawing.Point(30, 12);
            this.grupoBotones.Name = "grupoBotones";
            this.grupoBotones.Size = new System.Drawing.Size(576, 142);
            this.grupoBotones.TabIndex = 3;
            this.grupoBotones.TabStop = false;
            this.grupoBotones.Text = "Libro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 445);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button libro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button autor;
        private System.Windows.Forms.GroupBox grupoBotones;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

