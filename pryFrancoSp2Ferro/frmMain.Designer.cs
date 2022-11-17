namespace pryFrancoSp2Ferro
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.mrcCosto = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.mrcCosto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(276, 132);
            this.txtDistancia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistancia.MaxLength = 5;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(120, 22);
            this.txtDistancia.TabIndex = 1;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(111, 57);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(35, 16);
            this.lblDias.TabIndex = 3;
            this.lblDias.Text = "Dias";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(111, 132);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(63, 16);
            this.lblDistancia.TabIndex = 4;
            this.lblDistancia.Text = "Distancia";
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(276, 55);
            this.numUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(120, 22);
            this.numUpDown.TabIndex = 5;
            this.numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mrcCosto
            // 
            this.mrcCosto.Controls.Add(this.txtTotal);
            this.mrcCosto.Controls.Add(this.txtPrecio);
            this.mrcCosto.Controls.Add(this.lblTotal);
            this.mrcCosto.Controls.Add(this.lblPrecio);
            this.mrcCosto.Location = new System.Drawing.Point(115, 224);
            this.mrcCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcCosto.Name = "mrcCosto";
            this.mrcCosto.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mrcCosto.Size = new System.Drawing.Size(304, 142);
            this.mrcCosto.TabIndex = 6;
            this.mrcCosto.TabStop = false;
            this.mrcCosto.Text = "costo";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(163, 90);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(120, 22);
            this.txtTotal.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(163, 28);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 22);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.Text = "5$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(68, 90);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 16);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(37, 31);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(68, 16);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio Km";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.mrcCosto);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtDistancia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferro";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.mrcCosto.ResumeLayout(false);
            this.mrcCosto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.GroupBox mrcCosto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecio;
    }
}

