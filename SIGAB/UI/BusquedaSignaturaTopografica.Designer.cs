namespace UI
{
    partial class BusquedaSignaturaTopografica
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
            this.btnSalir = new Controles.ButtonUAI();
            this.dataGridViewUAI1 = new Controles.DataGridViewUAI();
            this.numericUpDownUAI1 = new Controles.NumericUpDownUAI();
            this.labelUAI1 = new Controles.LabelUAI();
            this.labelUAI2 = new Controles.LabelUAI();
            this.textBoxUAI1 = new Controles.TextBoxUAI();
            this.statusStripUAI1 = new Controles.StatusStripUAI();
            this.StatusLabelReg = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUAI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUAI1)).BeginInit();
            this.statusStripUAI1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(716, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 27);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUAI1
            // 
            this.dataGridViewUAI1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUAI1.Location = new System.Drawing.Point(0, 64);
            this.dataGridViewUAI1.Name = "dataGridViewUAI1";
            this.dataGridViewUAI1.Size = new System.Drawing.Size(800, 281);
            this.dataGridViewUAI1.TabIndex = 1;
            // 
            // numericUpDownUAI1
            // 
            this.numericUpDownUAI1.Location = new System.Drawing.Point(55, 38);
            this.numericUpDownUAI1.Name = "numericUpDownUAI1";
            this.numericUpDownUAI1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownUAI1.TabIndex = 2;
            // 
            // labelUAI1
            // 
            this.labelUAI1.AutoSize = true;
            this.labelUAI1.Location = new System.Drawing.Point(13, 40);
            this.labelUAI1.Name = "labelUAI1";
            this.labelUAI1.Size = new System.Drawing.Size(36, 13);
            this.labelUAI1.TabIndex = 3;
            this.labelUAI1.Text = "U.Info";
            // 
            // labelUAI2
            // 
            this.labelUAI2.AutoSize = true;
            this.labelUAI2.Location = new System.Drawing.Point(114, 40);
            this.labelUAI2.Name = "labelUAI2";
            this.labelUAI2.Size = new System.Drawing.Size(55, 13);
            this.labelUAI2.TabIndex = 4;
            this.labelUAI2.Text = "Busqueda";
            // 
            // textBoxUAI1
            // 
            this.textBoxUAI1.Location = new System.Drawing.Point(175, 38);
            this.textBoxUAI1.Name = "textBoxUAI1";
            this.textBoxUAI1.Size = new System.Drawing.Size(613, 20);
            this.textBoxUAI1.TabIndex = 5;
            // 
            // statusStripUAI1
            // 
            this.statusStripUAI1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelReg});
            this.statusStripUAI1.Location = new System.Drawing.Point(0, 367);
            this.statusStripUAI1.Name = "statusStripUAI1";
            this.statusStripUAI1.Size = new System.Drawing.Size(800, 24);
            this.statusStripUAI1.TabIndex = 6;
            this.statusStripUAI1.Text = "statusStripUAI1";
            // 
            // StatusLabelReg
            // 
            this.StatusLabelReg.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.StatusLabelReg.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.StatusLabelReg.Name = "StatusLabelReg";
            this.StatusLabelReg.Size = new System.Drawing.Size(56, 19);
            this.StatusLabelReg.Text = "registros";
            // 
            // BusquedaSignaturaTopografica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.statusStripUAI1);
            this.Controls.Add(this.textBoxUAI1);
            this.Controls.Add(this.labelUAI2);
            this.Controls.Add(this.labelUAI1);
            this.Controls.Add(this.numericUpDownUAI1);
            this.Controls.Add(this.dataGridViewUAI1);
            this.Controls.Add(this.btnSalir);
            this.Name = "BusquedaSignaturaTopografica";
            this.Text = "Busqueda por Signatura Topografica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUAI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUAI1)).EndInit();
            this.statusStripUAI1.ResumeLayout(false);
            this.statusStripUAI1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ButtonUAI btnSalir;
        private Controles.DataGridViewUAI dataGridViewUAI1;
        private Controles.NumericUpDownUAI numericUpDownUAI1;
        private Controles.LabelUAI labelUAI1;
        private Controles.LabelUAI labelUAI2;
        private Controles.TextBoxUAI textBoxUAI1;
        private Controles.StatusStripUAI statusStripUAI1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelReg;
    }
}