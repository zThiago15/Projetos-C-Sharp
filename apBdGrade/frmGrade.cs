using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Adicionar

namespace apBdGrade
{
    public partial class frmGrade : Form
    {
        public frmGrade()
        {
            InitializeComponent();
        }

        private void frmGrade_Load(object sender, EventArgs e)
        {
            /*
             * O evento Load ocorre quando o formulário é carregado.
             * Para entrar no código deste evento, dê dois cliques em qualquer lugar
             */
            //Define string de conexão
            MySqlConnection bdConecta;
            //Servidor: localhost
            //Banco de Dados: bd_vendas
            //id do usuário: root
            bdConecta = new MySqlConnection("server=localhost;database=bd_vendas;uid=root");

            //Neste caso a base de dados não tem password.
            //Abre conexão
            try //Verifica se a conexão abriu
            {
                bdConecta.Open();
            }
            catch //Se deu erro..
            {
                MessageBox.Show("Impossível estabelecer conexão");
                Close();
            }

            MessageBox.Show(" Conexão estabelecida");

            try // Tratamento de Excessão (Erro)
            {
                //cria o objeto command e armazena a consulta SQL
                MySqlCommand comando = new MySqlCommand("select * from tb_Cliente", bdConecta);
                //cria o objeto datareader para fazer a conexão com a tabela
                MySqlDataReader leitura = comando.ExecuteReader();

                MessageBox.Show("Acessou a tabela");
                //Faz a interação com o banco de dados lendo os dados da tabela
                while(leitura.Read())
                {
                    this.dgvDados.Rows.Add(leitura.GetInt32(0), leitura.GetString(1), leitura.GetString(2));
                }
                //fecha o reader
                leitura.Close();

            }

            catch //Se deu erro...
            {
                MessageBox.Show("Erro: acesso a tabela");
                Close();
            }
            finally // Executa sempre (se deu erro ou não)
            {
                //fecha a conexão 
                bdConecta.Close();
            }


        }
    }
}
