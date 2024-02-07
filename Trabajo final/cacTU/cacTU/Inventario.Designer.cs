namespace cacTU
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTop = new System.Windows.Forms.Panel();
            this.AñadirCactus = new System.Windows.Forms.Button();
            this.contenido = new System.Windows.Forms.Panel();
            this.cacTU = new System.Windows.Forms.Label();
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTop
            // 
            this.menuTop.Controls.Add(this.AñadirCactus);
            this.menuTop.Location = new System.Drawing.Point(13, 13);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(727, 87);
            this.menuTop.TabIndex = 0;
            // 
            // AñadirCactus
            // 
            this.AñadirCactus.Location = new System.Drawing.Point(67, 31);
            this.AñadirCactus.Name = "AñadirCactus";
            this.AñadirCactus.Size = new System.Drawing.Size(117, 23);
            this.AñadirCactus.TabIndex = 0;
            this.AñadirCactus.Text = "Añadir Nuevo Cactus";
            this.AñadirCactus.UseVisualStyleBackColor = true;
            this.AñadirCactus.Click += new System.EventHandler(this.AñadirCactus_Click);
            // 
            // contenido
            // 
            this.contenido.Location = new System.Drawing.Point(13, 107);
            this.contenido.Name = "contenido";
            this.contenido.Size = new System.Drawing.Size(939, 462);
            this.contenido.TabIndex = 1;
            // 
            // cacTU
            // 
            this.cacTU.AutoSize = true;
            this.cacTU.BackColor = System.Drawing.Color.Transparent;
            this.cacTU.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacTU.ForeColor = System.Drawing.Color.Indigo;
            this.cacTU.Location = new System.Drawing.Point(764, 13);
            this.cacTU.Name = "cacTU";
            this.cacTU.Size = new System.Drawing.Size(188, 80);
            this.cacTU.TabIndex = 2;
            this.cacTU.Text = "cacTÚ";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cacTU.Properties.Resources.backgroundcactus;
            this.ClientSize = new System.Drawing.Size(964, 581);
            this.Controls.Add(this.cacTU);
            this.Controls.Add(this.contenido);
            this.Controls.Add(this.menuTop);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.menuTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuTop;
        private System.Windows.Forms.Panel contenido;
        private System.Windows.Forms.Button AñadirCactus;
        private System.Windows.Forms.Label cacTU;
    }
}