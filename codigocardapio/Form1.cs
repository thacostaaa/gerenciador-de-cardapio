using System;
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

                dgCardapio.AllowUserToAddRows = true;

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgCardapio.Rows[0].Clone(); // Faz um cast e clona a linha da tabela
                    
                    row.Cells[0].Value = reader.GetInt32(0); // ID
                    row.Cells[1].Value = reader.GetString(1); // Nome
                    row.Cells[2].Value = reader.GetString(2); // Descrição
                    row.Cells[3].Value = reader.GetString(3); // Valor
                    row.Cells[4].Value = reader.GetString(4); // Valor com desconto
                    row.Cells[5].Value = reader.GetString(5); // Categoria
                    row.Cells[6].Value = reader.GetBoolean(7); // Sem açúcar
                    row.Cells[7].Value = reader.GetBoolean(8); // Sem glúten
                    row.Cells[8].Value = reader.GetBoolean(9); // Sem lactose
                    row.Cells[9].Value = reader.GetBoolean(10); // Vegetariano
                    row.Cells[10].Value = reader.GetBoolean(11); // Vegano

                    dgCardapio.Rows.Add(row); // Adiciona a linha na tabela
                }

                dgCardapio.AllowUserToAddRows = false;

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
            cbCategoria.SelectedIndex = -1;
            cbSemAcucar.Checked = false;
            cbSemGluten.Checked = false;
            cbSemLactose.Checked = false;
            cbVegetariano.Checked = false;
            cbVegano.Checked = false;
            tbID.Clear();

            btInserir.Enabled = true;
            btAlterar.Visible = false;
            btDeletar.Visible = false;

            // Foca no campo nome depois dos campo serem limpos
            tbNome.Focus();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            if (tbNome.Text == "" || tbValor.Text == "" || cbCategoria.Text == "")
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
                Console.WriteLine(cbSemAcucar.Checked);
                comandoMySql.CommandText = "INSERT INTO itemcardapio (nomeItem,descricaoItem,valorItem,valorComDesconto,categoriaItem,semAcucar,semGluten,semLactose,vegetariano,vegano) " +
                    "VALUES('" +
                    tbNome.Text + "', '" +
                    tbDescricao.Text + "', '" +
                    tbValor.Text + "', '" +
                    tbValorComDesconto.Text + "', '" +
                    cbCategoria.Text + "', '" +
                    Convert.ToInt16(cbSemAcucar.Checked) + "', '" +
                    Convert.ToInt16(cbSemGluten.Checked) + "', '" +
                    Convert.ToInt16(cbSemLactose.Checked) + "', '" +
                    Convert.ToInt16(cbVegetariano.Checked) + "', '" +
                    Convert.ToInt16(cbVegano.Checked) + "')";
                
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
                    "categoriaItem = '" + cbCategoria.Text + "', " +
                    "semAcucar = " + Convert.ToInt16(cbSemAcucar.Checked) + ", " +
                    "semGluten = " + Convert.ToInt16(cbSemGluten.Checked) + ", " +
                    "semLactose = " + Convert.ToInt16(cbSemLactose.Checked) + ", " +
                    "vegetariano = " + Convert.ToInt16(cbVegetariano.Checked) + ", " +
                    "vegano = " + Convert.ToInt16(cbVegano.Checked) + " " +
                    "WHERE idItem = " + tbID.Text;
                
                comandoMySql.ExecuteNonQuery();
                realizaConexaoBD.Close(); // Fecha a conexão com o banco
                
                MessageBox.Show("Atualizado com sucesso"); // Exibe mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open(); // Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand(); // Cria um comando SQL
                
                comandoMySql.CommandText =  "UPDATE itemcardapio SET ativoItem = 0 WHERE idItem = " + tbID.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexaoBD.Close(); // Fecha a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); // Exibe mensagem de aviso
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dgCardapio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                btInserir.Enabled = false;
                btAlterar.Visible = true;
                btDeletar.Visible = true;

                dgCardapio.CurrentRow.Selected = true;
                tbID.Text = dgCardapio.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
                tbNome.Text = dgCardapio.Rows[e.RowIndex].Cells["colNome"].FormattedValue.ToString();
                tbDescricao.Text = dgCardapio.Rows[e.RowIndex].Cells["colDescricao"].FormattedValue.ToString();
                tbValor.Text = dgCardapio.Rows[e.RowIndex].Cells["colValor"].FormattedValue.ToString();
                tbValorComDesconto.Text = dgCardapio.Rows[e.RowIndex].Cells["colValorcomDesconto"].FormattedValue.ToString();
                cbCategoria.Text = dgCardapio.Rows[e.RowIndex].Cells["colCategoria"].FormattedValue.ToString();
                cbSemAcucar.Checked = (bool)dgCardapio.Rows[e.RowIndex].Cells["colSemAcucar"].Value;
                cbSemGluten.Checked = (bool)dgCardapio.Rows[e.RowIndex].Cells["colSemGluten"].Value;
                cbSemLactose.Checked = (bool)dgCardapio.Rows[e.RowIndex].Cells["colSemLactose"].Value;
                cbVegetariano.Checked = (bool)dgCardapio.Rows[e.RowIndex].Cells["colVegetariano"].Value;
                cbVegano.Checked = (bool)dgCardapio.Rows[e.RowIndex].Cells["colVegano"].Value;

                // Após preencher os campos, seleciona o texto do campo nome
                tbNome.Select();
            }
        }
    }
}
