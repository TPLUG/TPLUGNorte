namespace SIGAB
{
    partial class BusquedaResponsable
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
            this.dataGridViewUAI1 = new Controles.DataGridViewUAI();
            this.dataGridViewUAI2 = new Controles.DataGridViewUAI();
            this.txtBoxBusqueda = new Controles.TextBoxUAI();
            this.labelUAI1 = new Controles.LabelUAI();
            this.rBtnBuscar = new Controles.RadioButtonUAI();
            this.rBtnAutor = new Controles.RadioButtonUAI();
            this.rBtnEditor = new Controles.RadioButtonUAI();
            this.rBtnResponsable = new Controles.RadioButtonUAI();
            this.btnSalir = new Controles.ButtonUAI();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUAI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUAI2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUAI1
            // 
            this.dataGridViewUAI1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUAI1.Location = new System.Drawing.Point(12, 35);
            this.dataGridViewUAI1.Name = "dataGridViewUAI1";
            this.dataGridViewUAI1.Size = new System.Drawing.Size(240, 266);
            this.dataGridViewUAI1.TabIndex = 0;
            // 
            // dataGridViewUAI2
            // 
            this.dataGridViewUAI2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUAI2.Location = new System.Drawing.Point(258, 35);
            this.dataGridViewUAI2.Name = "dataGridViewUAI2";
            this.dataGridViewUAI2.Size = new System.Drawing.Size(324, 266);
            this.dataGridViewUAI2.TabIndex = 1;
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(73, 307);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(509, 20);
            this.txtBoxBusqueda.TabIndex = 2;
            // 
            // labelUAI1
            // 
            this.labelUAI1.AutoSize = true;
            this.labelUAI1.Location = new System.Drawing.Point(12, 310);
            this.labelUAI1.Name = "labelUAI1";
            this.labelUAI1.Size = new System.Drawing.Size(55, 13);
            this.labelUAI1.TabIndex = 3;
            this.labelUAI1.Text = "Búsqueda";
            // 
            // rBtnBuscar
            // 
            this.rBtnBuscar.AutoSize = true;
            this.rBtnBuscar.Enabled = false;
            this.rBtnBuscar.Location = new System.Drawing.Point(11, 12);
            this.rBtnBuscar.Name = "rBtnBuscar";
            this.rBtnBuscar.Size = new System.Drawing.Size(58, 17);
            this.rBtnBuscar.TabIndex = 4;
            this.rBtnBuscar.TabStop = true;
            this.rBtnBuscar.Text = "Buscar";
            this.rBtnBuscar.UseVisualStyleBackColor = true;
            // 
            // rBtnAutor
            // 
            this.rBtnAutor.AutoSize = true;
            this.rBtnAutor.Location = new System.Drawing.Point(75, 12);
            this.rBtnAutor.Name = "rBtnAutor";
            this.rBtnAutor.Size = new System.Drawing.Size(50, 17);
            this.rBtnAutor.TabIndex = 5;
            this.rBtnAutor.TabStop = true;
            this.rBtnAutor.Text = "Autor";
            this.rBtnAutor.UseVisualStyleBackColor = true;
            // 
            // rBtnEditor
            // 
            this.rBtnEditor.AutoSize = true;
            this.rBtnEditor.Location = new System.Drawing.Point(131, 12);
            this.rBtnEditor.Name = "rBtnEditor";
            this.rBtnEditor.Size = new System.Drawing.Size(52, 17);
            this.rBtnEditor.TabIndex = 6;
            this.rBtnEditor.TabStop = true;
            this.rBtnEditor.Text = "Editor";
            this.rBtnEditor.UseVisualStyleBackColor = true;
            // 
            // rBtnResponsable
            // 
            this.rBtnResponsable.AutoSize = true;
            this.rBtnResponsable.Location = new System.Drawing.Point(189, 12);
            this.rBtnResponsable.Name = "rBtnResponsable";
            this.rBtnResponsable.Size = new System.Drawing.Size(124, 17);
            this.rBtnResponsable.TabIndex = 7;
            this.rBtnResponsable.TabStop = true;
            this.rBtnResponsable.Text = "Responsable edición";
            this.rBtnResponsable.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(503, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 26);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // BusquedaResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 339);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rBtnResponsable);
            this.Controls.Add(this.rBtnEditor);
            this.Controls.Add(this.rBtnAutor);
            this.Controls.Add(this.rBtnBuscar);
            this.Controls.Add(this.labelUAI1);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.dataGridViewUAI2);
            this.Controls.Add(this.dataGridViewUAI1);
            this.Name = "BusquedaResponsable";
            this.Text = "Búsqueda por Responsable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUAI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUAI2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.DataGridViewUAI dataGridViewUAI1;
        private Controles.DataGridViewUAI dataGridViewUAI2;
        private Controles.TextBoxUAI txtBoxBusqueda;
        private Controles.LabelUAI labelUAI1;
        private Controles.RadioButtonUAI rBtnBuscar;
        private Controles.RadioButtonUAI rBtnAutor;
        private Controles.RadioButtonUAI rBtnEditor;
        private Controles.RadioButtonUAI rBtnResponsable;
        private Controles.ButtonUAI btnSalir;
    }
}