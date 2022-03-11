namespace TransportesCR
{
    partial class MostrarCamionForm
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
            this.btnConsultaDatosCami = new System.Windows.Forms.Button();
            this.btnRegresaRegistroCamion = new System.Windows.Forms.Button();
            this.dataGrVwCamiones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrVwCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Los camiones registrados en la empresa son";
            // 
            // btnConsultaDatosCami
            // 
            this.btnConsultaDatosCami.Location = new System.Drawing.Point(353, 25);
            this.btnConsultaDatosCami.Name = "btnConsultaDatosCami";
            this.btnConsultaDatosCami.Size = new System.Drawing.Size(103, 36);
            this.btnConsultaDatosCami.TabIndex = 1;
            this.btnConsultaDatosCami.Text = "Consultar";
            this.btnConsultaDatosCami.UseVisualStyleBackColor = true;
            this.btnConsultaDatosCami.Click += new System.EventHandler(this.btnConsultaDatosCami_Click);
            // 
            // btnRegresaRegistroCamion
            // 
            this.btnRegresaRegistroCamion.Location = new System.Drawing.Point(619, 398);
            this.btnRegresaRegistroCamion.Name = "btnRegresaRegistroCamion";
            this.btnRegresaRegistroCamion.Size = new System.Drawing.Size(168, 35);
            this.btnRegresaRegistroCamion.TabIndex = 2;
            this.btnRegresaRegistroCamion.Text = "Regresar a Registro";
            this.btnRegresaRegistroCamion.UseVisualStyleBackColor = true;
            this.btnRegresaRegistroCamion.Click += new System.EventHandler(this.btnRegresaRegistroCamion_Click);
            // 
            // dataGrVwCamiones
            // 
            this.dataGrVwCamiones.AllowUserToAddRows = false;
            this.dataGrVwCamiones.AllowUserToDeleteRows = false;
            this.dataGrVwCamiones.AllowUserToResizeColumns = false;
            this.dataGrVwCamiones.AllowUserToResizeRows = false;
            this.dataGrVwCamiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrVwCamiones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrVwCamiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrVwCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrVwCamiones.Location = new System.Drawing.Point(12, 87);
            this.dataGrVwCamiones.Name = "dataGrVwCamiones";
            this.dataGrVwCamiones.ReadOnly = true;
            this.dataGrVwCamiones.RowHeadersWidth = 62;
            this.dataGrVwCamiones.RowTemplate.Height = 28;
            this.dataGrVwCamiones.Size = new System.Drawing.Size(776, 295);
            this.dataGrVwCamiones.TabIndex = 3;
            // 
            // MostrarCamionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrVwCamiones);
            this.Controls.Add(this.btnRegresaRegistroCamion);
            this.Controls.Add(this.btnConsultaDatosCami);
            this.Controls.Add(this.label1);
            this.Name = "MostrarCamionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Camion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrVwCamiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultaDatosCami;
        private System.Windows.Forms.Button btnRegresaRegistroCamion;
        private System.Windows.Forms.DataGridView dataGrVwCamiones;
    }
}