namespace GestaoPecuaria
{
    partial class FormListarAnimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.btListar = new System.Windows.Forms.Button();
            this.dgvListarAnimais = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarAnimais)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(974, 80);
            this.label1.TabIndex = 20;
            this.label1.Text = "Listar Animais";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.Blue;
            this.btListar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar.Location = new System.Drawing.Point(843, 503);
            this.btListar.Margin = new System.Windows.Forms.Padding(4);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(144, 39);
            this.btListar.TabIndex = 31;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // dgvListarAnimais
            // 
            this.dgvListarAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarAnimais.Location = new System.Drawing.Point(18, 92);
            this.dgvListarAnimais.Name = "dgvListarAnimais";
            this.dgvListarAnimais.RowHeadersWidth = 51;
            this.dgvListarAnimais.RowTemplate.Height = 24;
            this.dgvListarAnimais.Size = new System.Drawing.Size(969, 373);
            this.dgvListarAnimais.TabIndex = 32;
            // 
            // FormListarAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 555);
            this.Controls.Add(this.dgvListarAnimais);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.label1);
            this.Name = "FormListarAnimal";
            this.Text = "FormListarAnimal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarAnimais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.DataGridView dgvListarAnimais;
    }
}