namespace WebCrawler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Título = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exibições = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respostas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AtualizarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Título,
            this.Postagem,
            this.Exibições,
            this.Respostas,
            this.Link});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // Título
            // 
            this.Título.HeaderText = "Título";
            this.Título.Name = "Título";
            this.Título.Width = 300;
            // 
            // Postagem
            // 
            this.Postagem.HeaderText = "Postagem";
            this.Postagem.Name = "Postagem";
            this.Postagem.Width = 150;
            // 
            // Exibições
            // 
            this.Exibições.HeaderText = "Exibições";
            this.Exibições.Name = "Exibições";
            // 
            // Respostas
            // 
            this.Respostas.HeaderText = "Respostas";
            this.Respostas.Name = "Respostas";
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            // 
            // AtualizarButton
            // 
            this.AtualizarButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AtualizarButton.Location = new System.Drawing.Point(12, 12);
            this.AtualizarButton.Name = "AtualizarButton";
            this.AtualizarButton.Size = new System.Drawing.Size(134, 23);
            this.AtualizarButton.TabIndex = 1;
            this.AtualizarButton.Text = "Atualizar Lista";
            this.AtualizarButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AtualizarButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Título;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exibições;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respostas;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.Button AtualizarButton;
    }
}

