using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace codigocardapio
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();

            conexaoBD.Server = "localhost";
            conexaoBD.Database = "cardapio";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;

            return conexaoBD;
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM itemcardapio WHERE ativoItem = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgCardapio.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgCardapio.Rows[0].Clone(); //FAZ UM CAST E CLONA A LINHA DA TABELA
                    
                    row.Cells[0].Value = reader.GetInt32(0); //ID
                    row.Cells[1].Value = reader.GetString(1); //NOME
                    row.Cells[2].Value = reader.GetString(2); //DESCRICAO
                    row.Cells[3].Value = reader.GetString(3); //VALOR
                    row.Cells[4].Value = reader.GetString(4); //VALOR DESCONTO
                    row.Cells[5].Value = reader.GetString(5); //CATEGORIA
                    row.Cells[6].Value = reader.GetString(6); //RESTRICAO
                    
                    dgCardapio.Rows.Add(row); //ADICIONO A LINHA NA TABELA
                }

                realizaConexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void limparCampos()
        {
            tbNome.Clear();
            tbDescricao.Clear();
            tbValor.Clear();
            tbValorComDesconto.Clear();
            tbCategoria.Clear();
            tbRestricao.Clear();
            tbID.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            if (tbNome.Text == "" || tbValor.Text == "" || tbCategoria.Text == "")
            {
                MessageBox.Show("Os campos nome, valor e categoria são obrigatórios");

                return;
            }

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO itemcardapio (nomeItem,descricaoItem,valorItem,valorComDesconto,categoriaItem,restricaoItem) " +
                    "VALUES('" + tbNome.Text + "', '" + tbDescricao.Text + "', '" + tbValor.Text + "', '" + tbValorComDesconto.Text + "', '" + tbCategoria.Text + "', '" + tbRestricao.Text + "')";
                comandoMySql.ExecuteNonQuery();
                realizaConexacoBD.Close();

                MessageBox.Show("Inserido com sucesso");

                atualizarGrid();
                limparCampos();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "UPDATE itemcardapio SET nomeItem = '" + tbNome.Text + "', " +
                    "descricaoItem = '" + tbDescricao.Text + "', " +
                    "valorItem = '" + tbValor.Text + "', " +
                    "valorComDesconto = '" + tbValorComDesconto.Text + "', " +
                    "categoriaItem = '" + tbCategoria.Text + "', " +
                    "restricaoItem = '" + tbRestricao.Text + "' " +
                    "WHERE idItem = " + tbID.Text;
                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); //Crio um comando SQL
                //"DELETE FROM cardapio WHERE itemcardapio.`idItem` = "
                //comandoMySql.CommandText = "DELETE FROM cardapio WHERE idItem = " + tbID.Text + "";
                comandoMySql.CommandText =  "UPDATE itemcardapio SET ativoItem = 0 WHERE idItem = " + tbID.Text + "";
                
                
                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dgCardapio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCardapio.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgCardapio.CurrentRow.Selected = true;
                tbID.Text = dgCardapio.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
                tbNome.Text = dgCardapio.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                tbDescricao.Text = dgCardapio.Rows[e.RowIndex].Cells["colDescricao"].FormattedValue.ToString();
                tbValor.Text = dgCardapio.Rows[e.RowIndex].Cells["colValor"].FormattedValue.ToString();
                tbValorComDesconto.Text = dgCardapio.Rows[e.RowIndex].Cells["colValorcomDesconto"].FormattedValue.ToString();
                tbCategoria.Text = dgCardapio.Rows[e.RowIndex].Cells["colCategoria"].FormattedValue.ToString();
                tbRestricao.Text = dgCardapio.Rows[e.RowIndex].Cells["colRestricoes"].FormattedValue.ToString();
            }
        }
    }
}
