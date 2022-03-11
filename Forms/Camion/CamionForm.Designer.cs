namespace TransportesCR
{
    partial class CamionForm
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
            this.btnRegresarCamion = new System.Windows.Forms.Button();
            this.txtboxPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxModelo = new System.Windows.Forms.TextBox();
            this.txtboxMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxKG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxVL = new System.Windows.Forms.TextBox();
            this.btnGuardarCamion = new System.Windows.Forms.Button();
            this.btn_MostrarCamion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegresarCamion
            // 
            this.btnRegresarCamion.Location = new System.Drawing.Point(671, 398);
            this.btnRegresarCamion.Name = "btnRegresarCamion";
            this.btnRegresarCamion.Size = new System.Drawing.Size(105, 40);
            this.btnRegresarCamion.TabIndex = 0;
            this.btnRegresarCamion.Text = "Regresar";
            this.btnRegresarCamion.UseVisualStyleBackColor = true;
            this.btnRegresarCamion.Click += new System.EventHandler(this.btnRegresarCamion_Click);
            // 
            // txtboxPlaca
            // 
            this.txtboxPlaca.Location = new System.Drawing.Point(90, 43);
            this.txtboxPlaca.MaxLength = 8;
            this.txtboxPlaca.Name = "txtboxPlaca";
            this.txtboxPlaca.Size = new System.Drawing.Size(100, 26);
            this.txtboxPlaca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // txtboxModelo
            // 
            this.txtboxModelo.Location = new System.Drawing.Point(90, 112);
            this.txtboxModelo.MaxLength = 4;
            this.txtboxModelo.Name = "txtboxModelo";
            this.txtboxModelo.Size = new System.Drawing.Size(100, 26);
            this.txtboxModelo.TabIndex = 4;
            this.txtboxModelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxModelo_KeyPress);
            // 
            // txtboxMarca
            // 
            this.txtboxMarca.Location = new System.Drawing.Point(90, 189);
            this.txtboxMarca.MaxLength = 50;
            this.txtboxMarca.Name = "txtboxMarca";
            this.txtboxMarca.Size = new System.Drawing.Size(182, 26);
            this.txtboxMarca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capacidad de Kilogramos";
            // 
            // txtboxKG
            // 
            this.txtboxKG.Location = new System.Drawing.Point(228, 260);
            this.txtboxKG.MaxLength = 20;
            this.txtboxKG.Name = "txtboxKG";
            this.txtboxKG.Size = new System.Drawing.Size(194, 26);
            this.txtboxKG.TabIndex = 8;
            this.txtboxKG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxKG_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Capacidad de Volumen ";
            // 
            // txtboxVL
            // 
            this.txtboxVL.Location = new System.Drawing.Point(228, 324);
            this.txtboxVL.MaxLength = 20;
            this.txtboxVL.Name = "txtboxVL";
            this.txtboxVL.Size = new System.Drawing.Size(194, 26);
            this.txtboxVL.TabIndex = 10;
            this.txtboxVL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxVL_KeyPress);
            // 
            // btnGuardarCamion
            // 
            this.btnGuardarCamion.Location = new System.Drawing.Point(16, 398);
            this.btnGuardarCamion.Name = "btnGuardarCamion";
            this.btnGuardarCamion.Size = new System.Drawing.Size(105, 40);
            this.btnGuardarCamion.TabIndex = 11;
            this.btnGuardarCamion.Text = "Guardar";
            this.btnGuardarCamion.UseVisualStyleBackColor = true;
            this.btnGuardarCamion.Click += new System.EventHandler(this.btnGuardarCamion_Click);
            // 
            // btn_MostrarCamion
            // 
            this.btn_MostrarCamion.Location = new System.Drawing.Point(318, 398);
            this.btn_MostrarCamion.Name = "btn_MostrarCamion";
            this.btn_MostrarCamion.Size = new System.Drawing.Size(105, 40);
            this.btn_MostrarCamion.TabIndex = 12;
            this.btn_MostrarCamion.Text = "Mostrar";
            this.btn_MostrarCamion.UseVisualStyleBackColor = true;
            this.btn_MostrarCamion.Click += new System.EventHandler(this.btn_MostrarCamion_Click);
            // 
            // CamionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_MostrarCamion);
            this.Controls.Add(this.btnGuardarCamion);
            this.Controls.Add(this.txtboxVL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtboxKG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxMarca);
            this.Controls.Add(this.txtboxModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxPlaca);
            this.Controls.Add(this.btnRegresarCamion);
            this.Name = "CamionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Camiones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarCamion;
        private System.Windows.Forms.TextBox txtboxPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxModelo;
        private System.Windows.Forms.TextBox txtboxMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxKG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxVL;
        private System.Windows.Forms.Button btnGuardarCamion;
        private System.Windows.Forms.Button btn_MostrarCamion;
    }
}