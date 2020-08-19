namespace taller2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbNotas = new System.Windows.Forms.PictureBox();
            this.PbEdad = new System.Windows.Forms.PictureBox();
            this.PbVentas = new System.Windows.Forms.PictureBox();
            this.PbSalir = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOTAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "VENTAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PbNotas
            // 
            this.PbNotas.Image = ((System.Drawing.Image)(resources.GetObject("PbNotas.Image")));
            this.PbNotas.Location = new System.Drawing.Point(340, 189);
            this.PbNotas.Name = "PbNotas";
            this.PbNotas.Size = new System.Drawing.Size(100, 71);
            this.PbNotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbNotas.TabIndex = 5;
            this.PbNotas.TabStop = false;
            this.PbNotas.Click += new System.EventHandler(this.PbNotas_Click);
            // 
            // PbEdad
            // 
            this.PbEdad.Image = ((System.Drawing.Image)(resources.GetObject("PbEdad.Image")));
            this.PbEdad.Location = new System.Drawing.Point(114, 189);
            this.PbEdad.Name = "PbEdad";
            this.PbEdad.Size = new System.Drawing.Size(100, 71);
            this.PbEdad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbEdad.TabIndex = 6;
            this.PbEdad.TabStop = false;
            this.PbEdad.Click += new System.EventHandler(this.PbEdad_Click);
            // 
            // PbVentas
            // 
            this.PbVentas.Image = ((System.Drawing.Image)(resources.GetObject("PbVentas.Image")));
            this.PbVentas.Location = new System.Drawing.Point(557, 189);
            this.PbVentas.Name = "PbVentas";
            this.PbVentas.Size = new System.Drawing.Size(109, 71);
            this.PbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbVentas.TabIndex = 7;
            this.PbVentas.TabStop = false;
            this.PbVentas.Click += new System.EventHandler(this.PbVentas_Click);
            // 
            // PbSalir
            // 
            this.PbSalir.BackColor = System.Drawing.Color.Yellow;
            this.PbSalir.Image = ((System.Drawing.Image)(resources.GetObject("PbSalir.Image")));
            this.PbSalir.Location = new System.Drawing.Point(340, 317);
            this.PbSalir.Name = "PbSalir";
            this.PbSalir.Size = new System.Drawing.Size(100, 61);
            this.PbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSalir.TabIndex = 8;
            this.PbSalir.TabStop = false;
            this.PbSalir.Click += new System.EventHandler(this.PbSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SALIR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PbSalir);
            this.Controls.Add(this.PbVentas);
            this.Controls.Add(this.PbEdad);
            this.Controls.Add(this.PbNotas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PbNotas;
        private System.Windows.Forms.PictureBox PbEdad;
        private System.Windows.Forms.PictureBox PbVentas;
        private System.Windows.Forms.PictureBox PbSalir;
        private System.Windows.Forms.Label label5;
    }
}

