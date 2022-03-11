namespace TransportesCR.Forms.Asignacion
{
    partial class AsignacionForm
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
            this.btnRegresarAsignacion = new System.Windows.Forms.Button();
            this.cmbxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxPL = new System.Windows.Forms.ComboBox();
            this.dataGrVwAsignaciones = new System.Windows.Forms.DataGridView();
            this.btnConsultarAsignacion = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrVwAsignaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresarAsignacion
            // 
            this.btnRegresarAsignacion.Location = new System.Drawing.Point(671, 398);
            this.btnRegresarAsignacion.Name = "btnRegresarAsignacion";
            this.btnRegresarAsignacion.Size = new System.Drawing.Size(103, 36);
            this.btnRegresarAsignacion.TabIndex = 0;
            this.btnRegresarAsignacion.Text = "Regresar";
            this.btnRegresarAsignacion.UseVisualStyleBackColor = true;
            this.btnRegresarAsignacion.Click += new System.EventHandler(this.btnRegresarAsignacion_Click);
            // 
            // cmbxID
            // 
            this.cmbxID.FormattingEnabled = true;
            this.cmbxID.Location = new System.Drawing.Point(11, 52);
            this.cmbxID.Name = "cmbxID";
            this.cmbxID.Size = new System.Drawing.Size(136, 28);
            this.cmbxID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identificaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Placas";
            // 
            // cmbxPL
            // 
            this.cmbxPL.FormattingEnabled = true;
            this.cmbxPL.Location = new System.Drawing.Point(189, 52);
            this.cmbxPL.Name = "cmbxPL";
            this.cmbxPL.Size = new System.Drawing.Size(121, 28);
            this.cmbxPL.TabIndex = 5;
            // 
            // dataGrVwAsignaciones
            // 
            this.dataGrVwAsignaciones.AllowUserToAddRows = false;
            this.dataGrVwAsignaciones.AllowUserToDeleteRows = false;
            this.dataGrVwAsignaciones.AllowUserToResizeColumns = false;
            this.dataGrVwAsignaciones.AllowUserToResizeRows = false;
            this.dataGrVwAsignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrVwAsignaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrVwAsignaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrVwAsignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrVwAsignaciones.Location = new System.Drawing.Point(12, 123);
            this.dataGrVwAsignaciones.Name = "dataGrVwAsignaciones";
            this.dataGrVwAsignaciones.ReadOnly = true;
            this.dataGrVwAsignaciones.RowHeadersVisible = false;
            this.dataGrVwAsignaciones.RowHeadersWidth = 62;
            this.dataGrVwAsignaciones.RowTemplate.Height = 28;
            this.dataGrVwAsignaciones.Size = new System.Drawing.Size(776, 266);
            this.dataGrVwAsignaciones.TabIndex = 8;
            // 
            // btnConsultarAsignacion
            // 
            this.btnConsultarAsignacion.Location = new System.Drawing.Point(576, 44);
            this.btnConsultarAsignacion.Name = "btnConsultarAsignacion";
            this.btnConsultarAsignacion.Size = new System.Drawing.Size(103, 36);
            this.btnConsultarAsignacion.TabIndex = 9;
            this.btnConsultarAsignacion.Text = "Consultar";
            this.btnConsultarAsignacion.UseVisualStyleBackColor = true;
            this.btnConsultarAsignacion.Click += new System.EventHandler(this.btnConsultarAsignacion_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(419, 44);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(103, 36);
            this.btnAsignar.TabIndex = 10;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // AsignacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnConsultarAsignacion);
            this.Controls.Add(this.dataGrVwAsignaciones);
            this.Controls.Add(this.cmbxPL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxID);
            this.Controls.Add(this.btnRegresarAsignacion);
            this.Name = "AsignacionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignación";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrVwAsignaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresarAsignacion;
        private System.Windows.Forms.ComboBox cmbxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxPL;
        private System.Windows.Forms.DataGridView dataGrVwAsignaciones;
        private System.Windows.Forms.Button btnConsultarAsignacion;
        private System.Windows.Forms.Button btnAsignar;
    }
}