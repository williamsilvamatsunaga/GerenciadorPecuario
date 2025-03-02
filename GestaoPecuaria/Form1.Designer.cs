namespace GestaoPecuaria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrarAnimal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btAtualizarAnimal = new System.Windows.Forms.Button();
            this.btListarAnimal = new System.Windows.Forms.Button();
            this.btExcluirAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1035, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Gestão Pecuária";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCadastrarAnimal
            // 
            this.btCadastrarAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btCadastrarAnimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarAnimal.Location = new System.Drawing.Point(284, 178);
            this.btCadastrarAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastrarAnimal.Name = "btCadastrarAnimal";
            this.btCadastrarAnimal.Size = new System.Drawing.Size(185, 39);
            this.btCadastrarAnimal.TabIndex = 1;
            this.btCadastrarAnimal.Text = "Cadastrar Animal";
            this.btCadastrarAnimal.UseVisualStyleBackColor = false;
            this.btCadastrarAnimal.Click += new System.EventHandler(this.btCadastrarAnimal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // btAtualizarAnimal
            // 
            this.btAtualizarAnimal.BackColor = System.Drawing.Color.Yellow;
            this.btAtualizarAnimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarAnimal.Location = new System.Drawing.Point(578, 178);
            this.btAtualizarAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizarAnimal.Name = "btAtualizarAnimal";
            this.btAtualizarAnimal.Size = new System.Drawing.Size(185, 39);
            this.btAtualizarAnimal.TabIndex = 3;
            this.btAtualizarAnimal.Text = "Atualizar Animal";
            this.btAtualizarAnimal.UseVisualStyleBackColor = false;
            this.btAtualizarAnimal.Click += new System.EventHandler(this.btAtualizarAnimal_Click);
            // 
            // btListarAnimal
            // 
            this.btListarAnimal.BackColor = System.Drawing.Color.Blue;
            this.btListarAnimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarAnimal.Location = new System.Drawing.Point(284, 265);
            this.btListarAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btListarAnimal.Name = "btListarAnimal";
            this.btListarAnimal.Size = new System.Drawing.Size(185, 39);
            this.btListarAnimal.TabIndex = 4;
            this.btListarAnimal.Text = "Listar Animais";
            this.btListarAnimal.UseVisualStyleBackColor = false;
            this.btListarAnimal.Click += new System.EventHandler(this.btListarAnimal_Click);
            // 
            // btExcluirAnimal
            // 
            this.btExcluirAnimal.BackColor = System.Drawing.Color.Red;
            this.btExcluirAnimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirAnimal.Location = new System.Drawing.Point(578, 265);
            this.btExcluirAnimal.Margin = new System.Windows.Forms.Padding(4);
            this.btExcluirAnimal.Name = "btExcluirAnimal";
            this.btExcluirAnimal.Size = new System.Drawing.Size(185, 39);
            this.btExcluirAnimal.TabIndex = 6;
            this.btExcluirAnimal.Text = "Excluir Animal";
            this.btExcluirAnimal.UseVisualStyleBackColor = false;
            this.btExcluirAnimal.Click += new System.EventHandler(this.btExcluirAnimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btExcluirAnimal);
            this.Controls.Add(this.btListarAnimal);
            this.Controls.Add(this.btAtualizarAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCadastrarAnimal);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAtualizarAnimal;
        private System.Windows.Forms.Button btListarAnimal;
        private System.Windows.Forms.Button btExcluirAnimal;
    }
}

