namespace UI
{
    partial class AyudaForm
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
            this.buttonUAI1 = new Controles.ButtonUAI();
            this.comboBoxUAI1 = new Controles.ComboBoxUAI();
            this.labelUAI1 = new Controles.LabelUAI();
            this.labelUAI2 = new Controles.LabelUAI();
            this.textBoxUAI1 = new Controles.TextBoxUAI();
            this.dataGridViewUAI1 = new Controles.DataGridViewUAI();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUAI1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUAI1
            // 
            this.buttonUAI1.Location = new System.Drawing.Point(462, 272);
            this.buttonUAI1.Name = "buttonUAI1";
            this.buttonUAI1.Size = new System.Drawing.Size(78, 32);
            this.buttonUAI1.TabIndex = 0;
            this.buttonUAI1.Text = "Salir";
            this.buttonUAI1.UseVisualStyleBackColor = true;
            // 
            // comboBoxUAI1
            // 
            this.comboBoxUAI1.FormattingEnabled = true;
            this.comboBoxUAI1.Location = new System.Drawing.Point(73, 28);
            this.comboBoxUAI1.Name = "comboBoxUAI1";
            this.comboBoxUAI1.Size = new System.Drawing.Size(391, 24);
            this.comboBoxUAI1.TabIndex = 1;
            // 
            // labelUAI1
            // 
            this.labelUAI1.AutoSize = true;
            this.labelUAI1.Location = new System.Drawing.Point(23, 31);
            this.labelUAI1.Name = "labelUAI1";
            this.labelUAI1.Size = new System.Drawing.Size(44, 17);
            this.labelUAI1.TabIndex = 2;
            this.labelUAI1.Text = "Tabla";
            // 
            // labelUAI2
            // 
            this.labelUAI2.AutoSize = true;
            this.labelUAI2.Location = new System.Drawing.Point(13, 285);
            this.labelUAI2.Name = "labelUAI2";
            this.labelUAI2.Size = new System.Drawing.Size(44, 17);
            this.labelUAI2.TabIndex = 3;
            this.labelUAI2.Text = "Busq.";
            // 
            // textBoxUAI1
            // 
            this.textBoxUAI1.Location = new System.Drawing.Point(54, 282);
            this.textBoxUAI1.Name = "textBoxUAI1";
            this.textBoxUAI1.Size = new System.Drawing.Size(382, 22);
            this.textBoxUAI1.TabIndex = 4;
            // 
            // dataGridViewUAI1
            // 
            this.dataGridViewUAI1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUAI1.Location = new System.Drawing.Point(26, 73);
            this.dataGridViewUAI1.Name = "dataGridViewUAI1";
            this.dataGridViewUAI1.RowTemplate.Height = 24;
            this.dataGridViewUAI1.Size = new System.Drawing.Size(469, 181);
            this.dataGridViewUAI1.TabIndex = 5;
            // 
            // AyudaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 332);
            this.Controls.Add(this.dataGridViewUAI1);
            this.Controls.Add(this.textBoxUAI1);
            this.Controls.Add(this.labelUAI2);
            this.Controls.Add(this.labelUAI1);
            this.Controls.Add(this.comboBoxUAI1);
            this.Controls.Add(this.buttonUAI1);
            this.Name = "AyudaForm";
            this.Text = "AyudaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUAI1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.ButtonUAI buttonUAI1;
        private Controles.ComboBoxUAI comboBoxUAI1;
        private Controles.LabelUAI labelUAI1;
        private Controles.LabelUAI labelUAI2;
        private Controles.TextBoxUAI textBoxUAI1;
        private Controles.DataGridViewUAI dataGridViewUAI1;
    }
}