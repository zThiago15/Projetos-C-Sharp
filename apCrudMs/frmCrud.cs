using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apCrudMs
{
    public partial class frmCrud : Form
    {
        public frmCrud()
        {
            InitializeComponent();
        }
        MySqlConnection bdConecta;

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //Na ação do botão;
            //Define a string de conexão
            MySqlConnection bdConecta = new MySqlConnection("server = localhost; database = bd_vendas; uid = root");
            //Abre a conexão
            try
            {
                bdConecta.Open();
            }
            catch
            {
                MessageBox.Show("Impossível estabelecer conexão");
                Close();
            }

            //Verifica se a conexão está aberta
            MessageBox.Show(" conexão estabelecida");
            if (bdConecta.State == ConnectionState.Open)
            {
                //Se estiver aberta insere os dados na BD
                string strSql;
                strSql = "INSERT INTO tb_cliente VALUES(" + txtCodigo.Text + " ,\'" + txtNome.Text + "\',\'" + txtEndereco.Text + "\')";
                MessageBox.Show(strSql);
                MySqlCommand commS = new MySqlCommand(strSql, bdConecta);
                commS.ExecuteNonQuery(); 
                MessageBox.Show(" Incluído");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            {
                //Na ação do botão;
                //Define string de conexão
                MySqlConnection bdConecta = new MySqlConnection("server = localhost; database = bd_vendas; uid = root");
                //Neste caso a base de dados não tem password.
                //Abre a conexão
                try
                {
                    bdConecta.Open();
                }
                catch
                {
                    MessageBox.Show("Impossível estabelecer conexão");
                    Close();
                }
                //Verifica se a conexão está aberta
                MessageBox.Show(" conexão estabelecida");
                if (bdConecta.State == ConnectionState.Open)
                {
                    //Se estiver aberta insere os dados na BD
                    string strSql;
                    strSql = " UPDATE tb_cliente ";
                    strSql = strSql + "SET nome_cliente = \'" + txtNome.Text + "\', ";
                    strSql = strSql + "endereco = \'" + txtEndereco.Text+"\' ";
                    strSql = strSql + " WHERE codigo_cliente = " + txtCodigo.Text;

                    MessageBox.Show(strSql);
                    MySqlCommand commS = new MySqlCommand(strSql, bdConecta);
                    commS.ExecuteNonQuery();
                    MessageBox.Show(" Alterado");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Na ação do botão;
            //Define string de conexão
            MySqlConnection bdConecta = new MySqlConnection("server = localhost; database = bd_vendas; uid = root");
            //Neste caso a base de dados não tem password.
            //Abre a conexão
            try
            {
                bdConecta.Open();
            }
            catch
            {
                MessageBox.Show("Impossível estabelecer conexão ");
                Close();
            }
            //Verifica se a conexão está aberta
            MessageBox.Show(" conexão estabelecida");
            if (bdConecta.State == ConnectionState.Open)
            {
                //Exclui registro da tabela
                string strSql;
                strSql = "DELETE FROM tb_cliente WHERE codigo_cliente = " + txtCodigo.Text;
                MessageBox.Show(strSql);
                DialogResult resultado = MessageBox.Show("Confirm Exclusão?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    MySqlCommand commS = new MySqlCommand(strSql, bdConecta);
                    commS.ExecuteNonQuery();
                    MessageBox.Show(" Excluído");
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e) 
        {
            //Mesmo código do Load, poderia colocar o evento do click "Buscar" para executar o frmCrud.Load

            dgvDados.Rows.Clear();
            //cria a conexão com o banco de dados
            MySqlConnection bdConecta = new MySqlConnection("server = localhost; database = bd_vendas; uid = root");
            //cria o objeto command and armazena a consulta SQL
            MySqlCommand commS = new MySqlCommand("SELECT * FROM tb_cliente WHERE nome_cliente like " + "'%" +
    txtBusca.Text + "%'", bdConecta);
            try
            {
                bdConecta.Open();
                //cria o objeto datareader para fazer a conexão com a tabela
                MySqlDataReader Leitor = commS.ExecuteReader();

                //Faz a interação com o banco de dados lendo os dados da tabela
                while (Leitor.Read())
                {
                    this.dgvDados.Rows.Add(Leitor.GetInt32(0), Leitor.GetString(1), Leitor.GetString(2));
                }

                //fecha o reader
                Leitor.Close();
                //fecha a conexão
                bdConecta.Close();
            }

            //Trata a exceção
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            dgvDados.Rows.Clear();
            //cria a conexão com o banco de dados
            MySqlConnection bdConecta = new MySqlConnection("server = localhost; database = bd_vendas; uid = root");
            //cria o objeto command e armazena a consulta SQL
            MySqlCommand commS = new MySqlCommand("select * from tb_cliente where nome_cliente like " +
                "'%" + txtBusca.Text + "%'", bdConecta);
            try
            {
                bdConecta.Open();
                //cria o objeto datareader para fazer a conexão com a tabela
                MySqlDataReader Leitor = commS.ExecuteReader();

                //Faz a interação com o banco de dados lendo os dados da tabela
                while (Leitor.Read())
                {
                    this.dgvDados.Rows.Add(Leitor.GetInt32(0), Leitor.GetString(1), Leitor.GetString(2));
                }
                //fecha o reader
                Leitor.Close();
                //fecha a conexão
                bdConecta.Close();
            }
            //Trata a exceção
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Colaboradores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
