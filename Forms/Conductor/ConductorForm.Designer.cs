namespace TransportesCR
{
    partial class ConductorForm
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
            this.btnRegresarConductor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxIde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxApe1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxApe2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rchtxtboxRuta = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btn_MostrarConductor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresarConductor
            // 
            this.btnRegresarConductor.Location = new System.Drawing.Point(447, 259);
            this.btnRegresarConductor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresarConductor.Name = "btnRegresarConductor";
            this.btnRegresarConductor.Size = new System.Drawing.Size(70, 26);
            this.btnRegresarConductor.TabIndex = 0;
            this.btnRegresarConductor.Text = "Regresar";
            this.btnRegresarConductor.UseVisualStyleBackColor = true;
            this.btnRegresarConductor.Click += new System.EventHandler(this.btnRegresarConductor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identificación";
            // 
            // txtboxIde
            // 
            this.txtboxIde.Location = new System.Drawing.Point(101, 28);
            this.txtboxIde.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxIde.MaxLength = 10;
            this.txtboxIde.Name = "txtboxIde";
            this.txtboxIde.Size = new System.Drawing.Size(68, 20);
            this.txtboxIde.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(101, 67);
            this.txtboxNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxNom.MaxLength = 50;
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(123, 20);
            this.txtboxNom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Primer Apellido";
            // 
            // txtboxApe1
            // 
            this.txtboxApe1.Location = new System.Drawing.Point(101, 103);
            this.txtboxApe1.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxApe1.MaxLength = 50;
            this.txtboxApe1.Name = "txtboxApe1";
            this.txtboxApe1.Size = new System.Drawing.Size(123, 20);
            this.txtboxApe1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Segundo Apellido";
            // 
            // txtboxApe2
            // 
            this.txtboxApe2.Location = new System.Drawing.Point(101, 138);
            this.txtboxApe2.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxApe2.MaxLength = 50;
            this.txtboxApe2.Name = "txtboxApe2";
            this.txtboxApe2.Size = new System.Drawing.Size(123, 20);
            this.txtboxApe2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ruta";
            // 
            // rchtxtboxRuta
            // 
            this.rchtxtboxRuta.Location = new System.Drawing.Point(101, 179);
            this.rchtxtboxRuta.Margin = new System.Windows.Forms.Padding(2);
            this.rchtxtboxRuta.MaxLength = 200;
            this.rchtxtboxRuta.Name = "rchtxtboxRuta";
            this.rchtxtboxRuta.Size = new System.Drawing.Size(123, 38);
            this.rchtxtboxRuta.TabIndex = 11;
            this.rchtxtboxRuta.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(11, 259);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 26);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btn_MostrarConductor
            // 
            this.btn_MostrarConductor.Location = new System.Drawing.Point(212, 259);
            this.btn_MostrarConductor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MostrarConductor.Name = "btn_MostrarConductor";
            this.btn_MostrarConductor.Size = new System.Drawing.Size(70, 26);
            this.btn_MostrarConductor.TabIndex = 13;
            this.btn_MostrarConductor.Text = "Mostrar";
            this.btn_MostrarConductor.UseVisualStyleBackColor = true;
            this.btn_MostrarConductor.Click += new System.EventHandler(this.btn_MostrarConductor_Click);
            // 
            // ConductorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btn_MostrarConductor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rchtxtboxRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxApe2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxApe1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxIde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresarConductor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConductorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Conductores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarConductor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxIde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxApe1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxApe2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rchtxtboxRuta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btn_MostrarConductor;
    }
}