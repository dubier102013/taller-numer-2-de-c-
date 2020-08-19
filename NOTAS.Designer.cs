namespace taller2
{
    partial class NOTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NOTAS));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.TxtNota1 = new System.Windows.Forms.TextBox();
            this.TxtNota2 = new System.Windows.Forms.TextBox();
            this.TxtNota3 = new System.Windows.Forms.TextBox();
            this.TxtNota4 = new System.Windows.Forms.TextBox();
            this.TxtNota5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULAR PROMEDIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIGITE SU PRIMER NOTA :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIGITE SU SEGUNDA NOTA :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DIGITE SU TERCER NOTA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DIGITE SU CUARTA NOTA :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DIGITE SU QUINTA NOTA :";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(233, 355);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(69, 13);
            this.LblResultado.TabIndex = 6;
            this.LblResultado.Text = "LblResultado";
            this.LblResultado.Visible = false;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(383, 315);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(633, 252);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(129, 23);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "LIMPIAR CAMPOS";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Visible = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(633, 345);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(129, 23);
            this.BtnSalir.TabIndex = 9;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.Location = new System.Drawing.Point(633, 298);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(129, 23);
            this.BtnMenu.TabIndex = 10;
            this.BtnMenu.Text = "REGRESAR A MENU";
            this.BtnMenu.UseVisualStyleBackColor = true;
            this.BtnMenu.Visible = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // TxtNota1
            // 
            this.TxtNota1.Location = new System.Drawing.Point(383, 100);
            this.TxtNota1.Name = "TxtNota1";
            this.TxtNota1.Size = new System.Drawing.Size(100, 20);
            this.TxtNota1.TabIndex = 11;
            // 
            // TxtNota2
            // 
            this.TxtNota2.Location = new System.Drawing.Point(383, 140);
            this.TxtNota2.Name = "TxtNota2";
            this.TxtNota2.Size = new System.Drawing.Size(100, 20);
            this.TxtNota2.TabIndex = 12;
            // 
            // TxtNota3
            // 
            this.TxtNota3.Location = new System.Drawing.Point(383, 182);
            this.TxtNota3.Name = "TxtNota3";
            this.TxtNota3.Size = new System.Drawing.Size(100, 20);
            this.TxtNota3.TabIndex = 13;
            // 
            // TxtNota4
            // 
            this.TxtNota4.Location = new System.Drawing.Point(383, 225);
            this.TxtNota4.Name = "TxtNota4";
            this.TxtNota4.Size = new System.Drawing.Size(100, 20);
            this.TxtNota4.TabIndex = 14;
            // 
            // TxtNota5
            // 
            this.TxtNota5.Location = new System.Drawing.Point(383, 262);
            this.TxtNota5.Name = "TxtNota5";
            this.TxtNota5.Size = new System.Drawing.Size(100, 20);
            this.TxtNota5.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(633, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // NOTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtNota5);
            this.Controls.Add(this.TxtNota4);
            this.Controls.Add(this.TxtNota3);
            this.Controls.Add(this.TxtNota2);
            this.Controls.Add(this.TxtNota1);
            this.Controls.Add(this.BtnMenu);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NOTAS";
            this.Text = "NOTAS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.TextBox TxtNota1;
        private System.Windows.Forms.TextBox TxtNota2;
        private System.Windows.Forms.TextBox TxtNota3;
        private System.Windows.Forms.TextBox TxtNota4;
        private System.Windows.Forms.TextBox TxtNota5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}