namespace GestaoPecuaria
{
    partial class FormExcluirAnimal
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
            this.txtNomeNumeracaoAnimal2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1031, 80);
            this.label1.TabIndex = 20;
            this.label1.Text = "Excluir Animal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomeNumeracaoAnimal2
            // 
            this.txtNomeNumeracaoAnimal2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNumeracaoAnimal2.Location = new System.Drawing.Point(255, 203);
            this.txtNomeNumeracaoAnimal2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeNumeracaoAnimal2.Name = "txtNomeNumeracaoAnimal2";
            this.txtNomeNumeracaoAnimal2.Size = new System.Drawing.Size(561, 30);
            this.txtNomeNumeracaoAnimal2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome/Numeração:";
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Red;
            this.btExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(672, 371);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(144, 39);
            this.btExcluir.TabIndex = 31;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // FormExcluirAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 584);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.txtNomeNumeracaoAnimal2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormExcluirAnimal";
            this.Text = "FormExcluirAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeNumeracaoAnimal2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExcluir;
    }
}