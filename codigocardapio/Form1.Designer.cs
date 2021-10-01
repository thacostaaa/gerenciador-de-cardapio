
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbValorComDesconto = new System.Windows.Forms.TextBox();
            this.btInserir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.dgCardapio = new System.Windows.Forms.DataGridView();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSemAcucar = new System.Windows.Forms.CheckBox();
            this.cbSemGluten = new System.Windows.Forms.CheckBox();
            this.cbSemLactose = new System.Windows.Forms.CheckBox();
            this.cbVegetariano = new System.Windows.Forms.CheckBox();
            this.cbVegano = new System.Windows.Forms.CheckBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorComDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSemAcucar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSemGluten = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSemLactose = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colVegetariano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colVegano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardapio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor com desconto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // tbNome
            // 
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(11, 27);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(361, 20);
            this.tbNome.TabIndex = 0;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(12, 71);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(558, 20);
            this.tbDescricao.TabIndex = 2;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(17, 44);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(167, 20);
            this.tbValor.TabIndex = 1;
            // 
            // tbValorComDesconto
            // 
            this.tbValorComDesconto.Location = new System.Drawing.Point(18, 95);
            this.tbValorComDesconto.Name = "tbValorComDesconto";
            this.tbValorComDesconto.Size = new System.Drawing.Size(167, 20);
            this.tbValorComDesconto.TabIndex = 2;
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.SystemColors.Control;
            this.btInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInserir.Location = new System.Drawing.Point(713, 163);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 9;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Location = new System.Drawing.Point(632, 163);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 12;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // dgCardapio
            // 
            this.dgCardapio.AllowUserToDeleteRows = false;
            this.dgCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCardapio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colDescricao,
            this.colValor,
            this.colValorComDesconto,
            this.colCategoria,
            this.colSemAcucar,
            this.colSemGluten,
            this.colSemLactose,
            this.colVegetariano,
            this.colVegano});
            this.dgCardapio.Location = new System.Drawing.Point(12, 204);
            this.dgCardapio.MultiSelect = false;
            this.dgCardapio.Name = "dgCardapio";
            this.dgCardapio.Size = new System.Drawing.Size(776, 319);
            this.dgCardapio.TabIndex = 17;
            this.dgCardapio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCardapio_CellContentClick);
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletar.Location = new System.Drawing.Point(470, 163);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 11;
            this.btDeletar.Text = "Remover";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Visible = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Location = new System.Drawing.Point(551, 163);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Visible = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(12, 166);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 21;
            this.tbID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbVegano);
            this.groupBox1.Controls.Add(this.cbVegetariano);
            this.groupBox1.Controls.Add(this.cbSemLactose);
            this.groupBox1.Controls.Add(this.cbSemGluten);
            this.groupBox1.Controls.Add(this.cbSemAcucar);
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restrições";
            // 
            // cbSemAcucar
            // 
            this.cbSemAcucar.AutoSize = true;
            this.cbSemAcucar.Location = new System.Drawing.Point(22, 21);
            this.cbSemAcucar.Name = "cbSemAcucar";
            this.cbSemAcucar.Size = new System.Drawing.Size(83, 17);
            this.cbSemAcucar.TabIndex = 1;
            this.cbSemAcucar.Text = "Sem açúcar";
            this.cbSemAcucar.UseVisualStyleBackColor = true;
            // 
            // cbSemGluten
            // 
            this.cbSemGluten.AutoSize = true;
            this.cbSemGluten.Location = new System.Drawing.Point(136, 21);
            this.cbSemGluten.Name = "cbSemGluten";
            this.cbSemGluten.Size = new System.Drawing.Size(79, 17);
            this.cbSemGluten.TabIndex = 2;
            this.cbSemGluten.Text = "Sem glúten";
            this.cbSemGluten.UseVisualStyleBackColor = true;
            // 
            // cbSemLactose
            // 
            this.cbSemLactose.AutoSize = true;
            this.cbSemLactose.Location = new System.Drawing.Point(246, 21);
            this.cbSemLactose.Name = "cbSemLactose";
            this.cbSemLactose.Size = new System.Drawing.Size(84, 17);
            this.cbSemLactose.TabIndex = 3;
            this.cbSemLactose.Text = "Sem lactose";
            this.cbSemLactose.UseVisualStyleBackColor = true;
            // 
            // cbVegetariano
            // 
            this.cbVegetariano.AutoSize = true;
            this.cbVegetariano.Location = new System.Drawing.Point(361, 21);
            this.cbVegetariano.Name = "cbVegetariano";
            this.cbVegetariano.Size = new System.Drawing.Size(83, 17);
            this.cbVegetariano.TabIndex = 4;
            this.cbVegetariano.Text = "Vegetariano";
            this.cbVegetariano.UseVisualStyleBackColor = true;
            // 
            // cbVegano
            // 
            this.cbVegano.AutoSize = true;
            this.cbVegano.Location = new System.Drawing.Point(475, 21);
            this.cbVegano.Name = "cbVegano";
            this.cbVegano.Size = new System.Drawing.Size(63, 17);
            this.cbVegano.TabIndex = 5;
            this.cbVegano.Text = "Vegano";
            this.cbVegano.UseVisualStyleBackColor = true;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.cbCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "Bebida",
            "Petisco",
            "Pratos",
            "Sobremesa"});
            this.cbCategoria.Location = new System.Drawing.Point(391, 27);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(179, 21);
            this.cbCategoria.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbValorComDesconto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbValor);
            this.groupBox2.Location = new System.Drawing.Point(586, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preço";
            // 
            // colID
            // 
            this.colID.Frozen = true;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 30;
            // 
            // colNome
            // 
            this.colNome.Frozen = true;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 150;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 280;
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            this.colValor.Width = 65;
            // 
            // colValorComDesconto
            // 
            this.colValorComDesconto.HeaderText = "Valor com desconto";
            this.colValorComDesconto.Name = "colValorComDesconto";
            this.colValorComDesconto.ReadOnly = true;
            this.colValorComDesconto.Width = 65;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoria";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colSemAcucar
            // 
            this.colSemAcucar.HeaderText = "Sem açúcar";
            this.colSemAcucar.Name = "colSemAcucar";
            this.colSemAcucar.ReadOnly = true;
            this.colSemAcucar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSemAcucar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSemAcucar.Width = 90;
            // 
            // colSemGluten
            // 
            this.colSemGluten.HeaderText = "Sem glúten";
            this.colSemGluten.Name = "colSemGluten";
            this.colSemGluten.ReadOnly = true;
            this.colSemGluten.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSemGluten.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSemGluten.Width = 90;
            // 
            // colSemLactose
            // 
            this.colSemLactose.HeaderText = "Sem lactose";
            this.colSemLactose.Name = "colSemLactose";
            this.colSemLactose.ReadOnly = true;
            this.colSemLactose.Width = 90;
            // 
            // colVegetariano
            // 
            this.colVegetariano.HeaderText = "Vegetariano";
            this.colVegetariano.Name = "colVegetariano";
            this.colVegetariano.ReadOnly = true;
            this.colVegetariano.Width = 90;
            // 
            // colVegano
            // 
            this.colVegano.HeaderText = "Vegano";
            this.colVegano.Name = "colVegano";
            this.colVegano.ReadOnly = true;
            this.colVegano.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.dgCardapio);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Cardápio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCardapio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbValorComDesconto;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.DataGridView dgCardapio;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbVegano;
        private System.Windows.Forms.CheckBox cbVegetariano;
        private System.Windows.Forms.CheckBox cbSemLactose;
        private System.Windows.Forms.CheckBox cbSemGluten;
        private System.Windows.Forms.CheckBox cbSemAcucar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorComDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSemAcucar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSemGluten;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSemLactose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colVegetariano;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colVegano;
    }
}

