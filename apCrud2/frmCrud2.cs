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

namespace apCrud2
{
    public partial class frmCrud2 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public frmCrud2()
        {
            InitializeComponent();
        }

        private void frmCrud2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("server = localhost; database = bd_cd; uid = root; ");

                strSQL = "INSERT INTO tb_musica (NOMEMUSICA, DURACAO) VALUES (@NOMEMUSICA, @DURACAO)";

                comando = new MySqlCommand(strSQL, conexao);
                //comando.Parameters.AddWithValue("@CODIGOMUSICA", txtCodigo.Text); Não é obrigatório preencher já que está como auto incremento
                comando.Parameters.AddWithValue("@NOMEMUSICA", txtNome.Text);
                comando.Parameters.AddWithValue("@DURACAO", txtDuracao.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("server = localhost; database = bd_cd; uid = root; ");

                strSQL = "UPDATE TB_MUSICA SET NOMEMUSICA = @NOMEMUSICA, DURACAO = @DURACAO WHERE CODIGOMUSICA = @CODIGOMUSICA";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CODIGOMUSICA", txtCodigo.Text);
                comando.Parameters.AddWithValue("@NOMEMUSICA", txtNome.Text);
                comando.Parameters.AddWithValue("@DURACAO", txtDuracao.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("server = localhost; database = bd_cd; uid = root; ");

                strSQL = "DELETE FROM tb_musica WHERE CODIGOMUSICA = @CODIGOMUSICA";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CODIGOMUSICA", txtCodigo.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("server = localhost; database = bd_cd; uid = root; ");

                strSQL = "SELECT * FROM tb_musica WHERE CODIGOMUSICA = @CODIGOMUSICA";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@CODIGOMUSICA", txtCodigo.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = Convert.ToString(dr["nomemusica"]);
                    txtDuracao.Text = Convert.ToString(dr["duracao"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("server = localhost; database = bd_cd; uid = root; ");

                strSQL = "SELECT * FROM tb_musica";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvDados.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
