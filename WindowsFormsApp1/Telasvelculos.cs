using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Telasvelculos : Form
    {
        public Telasvelculos()
        {
            InitializeComponent();
        }

        const string DADOS_CONEXAO =
        "Server=localhost;user=root;password=;database=projeto";

        private void Telasvelculos_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            string campoplaca = lbPlaca.Text;
            int controleLinhasAfetadas = 0;
            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scriptDelete = "DELETE FROM tb_carros  where nome = @nome";
                using (MySqlCommand comando = new MySqlCommand(scriptDelete, conn))
                {
                    comando.Parameters.AddWithValue("@placa", campoplaca);

                    controleLinhasAfetadas = comando.ExecuteNonQuery();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)

        {

            string campoNome = txtnome.Text;

            string campoTelefone = txttelefone.Text;

            string campoPlaca = textPlaca.Text;

            string campoModelo = txtModelo.Text;

            string campoMarca = textMarca.Text;

            string campoAno = dtpAno.Text;

           // CORRIGIDO: Captura apenas o número do ano (ex: 2026) para enviar ao banco INTint campoAno = dtpAno.Value.Year;


            string campoCor = txtcor.Text;

            string campoQuilometragem = nudQuilometragem.Value.ToString();


            int controleLinhasAfetadas = 0;


            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))

            {

                conn.Open();

                string scriptInsert = "INSERT INTO tb_carros (placa, modelo, marca, ano, cor, quilometragem, nome, telefone) " +

                      "VALUES (@placa, @modelo, @marca, @ano, @cor, @quilometragem, @nome, @telefone)";


                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))

                {

                    comando.Parameters.AddWithValue("@nome", campoNome);

                    comando.Parameters.AddWithValue("@telefone", campoTelefone);

                    comando.Parameters.AddWithValue("@placa", campoPlaca);

                    comando.Parameters.AddWithValue("@modelo", campoModelo); // Enviando o ano como númerocomando.Parameters.AddWithValue("@cor", campoCor);

                    comando.Parameters.AddWithValue("@marca", campoMarca);

                    comando.Parameters.AddWithValue("@ano", campoAno);

                    comando.Parameters.AddWithValue("@cor", campoCor);

                    comando.Parameters.AddWithValue("@quilometragem", campoQuilometragem);



                    // CORRIGIDO: Faltava esta linha para realmente executar o comando no MySQLcontroleLinhasAfetadas = comando.ExecuteNonQuery();

                }

                conn.Close();

            }
            if (controleLinhasAfetadas > 0)

            {

                MessageBox.Show("Dados salvos com sucesso!");

            }

            else
            {

                MessageBox.Show("Ops, Algo deu errado!!!");

            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scriptConsultaIndividual = "SETECT * FROM  tb_carros WHERE id = 1";

                using (MySqlCommand comando = new MySqlCommand(scriptConsultaIndividual, conn))
                {
                    var dadosResultado = comando.ExecuteReader();

                    while (dadosResultado.Read())
                    {
                        // lbidResultado.text = dadosResultado["id"].ToString();
                        //lbNomeResultado.text = dadosResultado["nomeVendendor"].ToString();
                        //lbResultado.text = dadosResultado["telefone"].ToString();
                        //lbDataResultado.text = dadosResultado["ano"].ToString();
                    }
                    conn.Close();
                }
            }
        }

        private void btnConsultarLista_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();

                string campoplaca = lbPlaca.Text;
                string scriptConsultaLista = "";
                if (!string.IsNullOrEmpty(campoplaca))
                {
                    scriptConsultaLista = $"SELECT * FROM tb_carros  WHERE nomeVendendor LIKE '%{campoplaca}%'";
                }
                else
                {
                    scriptConsultaLista = "SELECT * FROM tb_carros ";
                }

                string scriptCosulta = "SELECT * FROM tb_carros ";

                using (MySqlCommand comando = new MySqlCommand(scriptCosulta, conn))
                {
                    if (!string.IsNullOrEmpty(campoplaca))
                    {
                        comando.Parameters.AddWithValue("@nomeVendendor", $"%{campoplaca}%");
                    }
                    MySqlDataAdapter resultadoConsultaMySql = new MySqlDataAdapter(comando);

                    DataTable dt = new DataTable();

                    resultadoConsultaMySql.Fill(dt);

                    dgvCarro.DataSource = dt;



                }
                conn.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            {
                string camponome = txtnome.Text;

                string campotelefone = txttelefone.Text;

                string campoPlaca = textPlaca.Text;

                string campoAno = dtpAno.Text;

                string campoquilometragem = nudQuilometragem.Text;

                string campoModelo = txtModelo.Text;

                string campoMarca = textMarca.Text;


                // Captura apenas o ano selecionado no DateTimePickerint campoAno = dtpAno.Value.Year;


                string campoCor = txtcor.Text;


                // Captura o valor numérico do NumericUpDowndecimal campoQuilometragem = nudQuilometragem.Value;


                int controleLinhasAfetadas = 0;


                using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))

                {

                    // utilize das informaçõesc