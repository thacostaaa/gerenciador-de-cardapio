
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbValorComDesconto = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbRestricao = new System.Windows.Forms.TextBox();
            this.btInserir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgCardapio = new System.Windows.Forms.DataGridView();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorComDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestricoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardapio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor com desconto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Restrições";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(11, 27);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(171, 20);
            this.tbNome.TabIndex = 0;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(213, 27);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(574, 20);
            this.tbDescricao.TabIndex = 1;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(11, 76);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(171, 20);
            this.tbValor.TabIndex = 2;
            // 
            // tbValorComDesconto
            // 
            this.tbValorComDesconto.Location = new System.Drawing.Point(213, 76);
            this.tbValorComDesconto.Name = "tbValorComDesconto";
            this.tbValorComDesconto.Size = new System.Drawing.Size(171, 20);
            this.tbValorComDesconto.TabIndex = 3;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(415, 76);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(171, 20);
            this.tbCategoria.TabIndex = 4;
            // 
            // tbRestricao
            // 
            this.tbRestricao.Location = new System.Drawing.Point(617, 76);
            this.tbRestricao.Name = "tbRestricao";
            this.tbRestricao.Size = new System.Drawing.Size(171, 20);
            this.tbRestricao.TabIndex = 5;
            // 
            // btInserir
            // 
            this.btInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserir.Location = new System.Drawing.Point(713, 115);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 6;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Location = new System.Drawing.Point(632, 115);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 9;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgCardapio
            // 
            this.dgCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCardapio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colDescricao,
            this.colValor,
            this.colValorComDesconto,
            this.colCategoria,
            this.colRestricoes});
            this.dgCardapio.Location = new System.Drawing.Point(11, 155);
            this.dgCardapio.Name = "dgCardapio";
            this.dgCardapio.Size = new System.Drawing.Size(776, 293);
            this.dgCardapio.TabIndex = 17;
            this.dgCardapio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCardapio_CellContentClick);
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletar.Location = new System.Drawing.Point(470, 115);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 8;
            this.btDeletar.Text = "Remover";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Visible = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Location = new System.Drawing.Point(551, 115);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 7;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Visible = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(12, 117);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 21;
            this.tbID.Visible = false;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 30;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 293;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Width = 50;
            // 
            // colValorComDesconto
            // 
            this.colValorComDesconto.HeaderText = "Valor com desconto";
            this.colValorComDesconto.Name = "colValorComDesconto";
            this.colValorComDesconto.Width = 60;
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
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.dgCardapio);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.tbRestricao);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbValorComDesconto);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbNome);
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
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbValorComDesconto;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbRestricao;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgCardapio;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorComDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestricoes;
    }
}

