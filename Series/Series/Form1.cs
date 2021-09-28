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

namespace Series
{
    public partial class formseries : Form
    {
        public formseries()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoDB = new MySqlConnectionStringBuilder();
            conexaoDB.Server = "127.0.0.1";
            conexaoDB.Database = "db_series";
            conexaoDB.UserID = "root";
            conexaoDB.Password = "";
            conexaoDB.SslMode = 0;
            return conexaoDB;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void limpar_Click(object sender, EventArgs e)
        {
            tbNome.Clear();
            tbTemporadas.Clear();
            tbAssistir.Clear();
            tbGenero.Clear();
            tbAno.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formseries_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoDB = conexaoBanco();
            MySqlConnection realizaConexaoDB = new MySqlConnection(conexaoDB.ToString());

            try
            {
                realizaConexaoDB.Open();
                MySqlCommand comandoMySql = realizaConexaoDB.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM tb_series";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dgSeries.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgSeries.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetString(5); // ID
                    row.Cells[1].Value = reader.GetString(0); // NOME
                    row.Cells[2].Value = reader.GetString(1); // TEMPORADAS
                    row.Cells[3].Value = reader.GetString(2); // ONDE ASSISTIR
                    row.Cells[4].Value = reader.GetString(4); // ANO
                    row.Cells[5].Value = reader.GetString(3); // GÊNERO                    
                    dgSeries.Rows.Add(row);
                }

                realizaConexaoDB.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoDB = conexaoBanco();
            MySqlConnection realizaConexaoDB = new MySqlConnection(conexaoDB.ToString());

            try
            {
                realizaConexaoDB.Open();
                MySqlCommand comandoMySql = realizaConexaoDB.CreateCommand();
                comandoMySql.CommandText = "INSERT INTO tb_series (nome, numero_temporadas, onde_assistir, genero, ano)"
                    + "VALUES(" + tbNome.Text + "," +  Convert.ToInt16(tbTemporadas.Text) + "," + tbAssistir.Text + "," + tbGenero.Text + "," + Convert.ToInt16(tbAno.Text) + ")";
                comandoMySql.ExecuteNonQuery();
                
                realizaConexaoDB.Close();
                MessageBox.Show("Inserido com Sucesso");
                atualizarGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
