namespace TransportesCR
{
    partial class TransportesCRForm
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
            this.btnConductor = new System.Windows.Forms.Button();
            this.btnCamion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAsignacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConductor
            // 
            this.btnConductor.Location = new System.Drawing.Point(12, 405);
            this.btnConductor.Name = "btnConductor";
            this.btnConductor.Size = new System.Drawing.Size(104, 33);
            this.btnConductor.TabIndex = 0;
            this.btnConductor.Text = "Conductor";
            this.btnConductor.UseVisualStyleBackColor = true;
            this.btnConductor.Click += new System.EventHandler(this.btnConductor_Click);
            // 
            // btnCamion
            // 
            this.btnCamion.Location = new System.Drawing.Point(212, 405);
            this.btnCamion.Name = "btnCamion";
            this.btnCamion.Size = new System.Drawing.Size(104, 33);
            this.btnCamion.TabIndex = 1;
            this.btnCamion.Text = "Camión";
            this.btnCamion.UseVisualStyleBackColor = true;
            this.btnCamion.Click += new System.EventHandler(this.btnCamion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(612, 405);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 33);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAsignacion
            // 
            this.btnAsignacion.Location = new System.Drawing.Point(412, 405);
            this.btnAsignacion.Name = "btnAsignacion";
            this.btnAsignacion.Size = new System.Drawing.Size(104, 33);
            this.btnAsignacion.TabIndex = 3;
            this.btnAsignacion.Text = "Asignación";
            this.btnAsignacion.UseVisualStyleBackColor = true;
            this.btnAsignacion.Click += new System.EventHandler(this.btnAsignacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 59);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transportes CR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Olman Umaña Paladino. 114230141";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "UNED. Programación Avanzada";
            // 
            // TransportesCRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsignacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCamion);
            this.Controls.Add(this.btnConductor);
            this.Name = "TransportesCRForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransportesCR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConductor;
        private System.Windows.Forms.Button btnCamion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAsignacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

