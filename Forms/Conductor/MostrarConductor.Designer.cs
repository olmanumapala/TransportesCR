namespace TransportesCR
{
    partial class MostrarConductorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrVwConductores = new System.Windows.Forms.DataGridView();
            this.btnRegresaRegistroConductor = new System.Windows.Forms.Button();
            this.btnConsultaDatosConduc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrVwConductores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Los conductores registrados son";
            // 
            // dataGrVwConductores
            // 
            this.dataGrVwConductores.AllowUserToAddRows = false;
            this.dataGrVwConductores.AllowUserToDeleteRows = false;
            this.dataGrVwConductores.AllowUserToResizeColumns = false;
            this.dataGrVwConductores.AllowUserToResizeRows = false;
            this.dataGrVwConductores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrVwConductores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrVwConductores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrVwConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrVwConductores.Location = new System.Drawing.Point(12, 87);
            this.dataGrVwConductores.Name = "dataGrVwConductores";
            this.dataGrVwConductores.ReadOnly = true;
            this.dataGrVwConductores.RowHeadersVisible = false;
            this.dataGrVwConductores.RowHeadersWidth = 62;
            this.dataGrVwConductores.RowTemplate.Height = 28;
            this.dataGrVwConductores.Size = new System.Drawing.Size(776, 295);
            this.dataGrVwConductores.TabIndex = 1;
            // 
            // btnRegresaRegistroConductor
            // 
            this.btnRegresaRegistroConductor.Location = new System.Drawing.Point(619, 398);
            this.btnRegresaRegistroConductor.Name = "btnRegresaRegistroConductor";
            this.btnRegresaRegistroConductor.Size = new System.Drawing.Size(168, 35);
            this.btnRegresaRegistroConductor.TabIndex = 2;
            this.btnRegresaRegistroConductor.Text = "Regresar a Registro";
            this.btnRegresaRegistroConductor.UseVisualStyleBackColor = true;
            this.btnRegresaRegistroConductor.Click += new System.EventHandler(this.btnRegresaRegistroConductor_Click);
            // 
            // btnConsultaDatosConduc
            // 
            this.btnConsultaDatosConduc.Location = new System.Drawing.Point(289, 25);
            this.btnConsultaDatosConduc.Name = "btnConsultaDatosConduc";
            this.btnConsultaDatosConduc.Size = new System.Drawing.Size(103, 36);
            this.btnConsultaDatosConduc.TabIndex = 3;
            this.btnConsultaDatosConduc.Text = "Consultar";
            this.btnConsultaDatosConduc.UseVisualStyleBackColor = true;
            this.btnConsultaDatosConduc.Click += new System.EventHandler(this.btnConsultaDatosConduc_Click);
            // 
            // MostrarConductorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultaDatosConduc);
            this.Controls.Add(this.btnRegresaRegistroConductor);
            this.Controls.Add(this.dataGrVwConductores);
            this.Controls.Add(this.label1);
            this.Name = "MostrarConductorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Conductor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrVwConductores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrVwConductores;
        private System.Windows.Forms.Button btnRegresaRegistroConductor;
        private System.Windows.Forms.Button btnConsultaDatosConduc;
    }
}