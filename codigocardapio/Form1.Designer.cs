
namespace codigocardapio
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbValorDesconto = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbRestricoes = new System.Windows.Forms.TextBox();
            this.btInserir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.dgCardapio = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestricoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardapio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Desconto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Restrições";
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(75, 20);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(100, 20);
            this.tbItem.TabIndex = 6;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(75, 57);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(100, 20);
            this.tbDescricao.TabIndex = 7;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(75, 92);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(100, 20);
            this.tbValor.TabIndex = 8;
            // 
            // tbValorDesconto
            // 
            this.tbValorDesconto.Location = new System.Drawing.Point(334, 20);
            this.tbValorDesconto.Name = "tbValorDesconto";
            this.tbValorDesconto.Size = new System.Drawing.Size(100, 20);
            this.tbValorDesconto.TabIndex = 9;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(334, 58);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(98, 20);
            this.tbCategoria.TabIndex = 10;
            // 
            // tbRestricoes
            // 
            this.tbRestricoes.Location = new System.Drawing.Point(333, 92);
            this.tbRestricoes.Name = "tbRestricoes";
            this.tbRestricoes.Size = new System.Drawing.Size(100, 20);
            this.tbRestricoes.TabIndex = 11;
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(500, 17);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 12;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(500, 55);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 13;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(500, 92);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 14;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btFiltrar
            // 
            this.btFiltrar.Location = new System.Drawing.Point(598, 37);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btFiltrar.TabIndex = 15;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(598, 82);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 16;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            // 
            // dgCardapio
            // 
            this.dgCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCardapio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colItem,
            this.colDescricao,
            this.colValor,
            this.colValorDesconto,
            this.colCategoria,
            this.colRestricoes});
            this.dgCardapio.Location = new System.Drawing.Point(8, 144);
            this.dgCardapio.Name = "dgCardapio";
            this.dgCardapio.Size = new System.Drawing.Size(778, 195);
            this.dgCardapio.TabIndex = 17;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 30;
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 300;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 50;
            // 
            // colValorDesconto
            // 
            this.colValorDesconto.HeaderText = "Valor Desconto";
            this.colValorDesconto.Name = "colValorDesconto";
            this.colValorDesconto.Width = 60;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            // 
            // colRestricoes
            // 
            this.colRestricoes.HeaderText = "Restrições";
            this.colRestricoes.Name = "colRestricoes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgCardapio);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.tbRestricoes);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbValorDesconto);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Cardapio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCardapio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbValorDesconto;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbRestricoes;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.DataGridView dgCardapio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestricoes;
    }
}

