using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_inclusiON
{
    public partial class frmEstagiarios: Form
    {
        public frmEstagiarios()
        {
            InitializeComponent();
        }

        private void btnSalvarEstagiario_Click(object sender, EventArgs e)
        {
            //os blocos try e catch são usados para tratamento de exceções, ou seja, para lidar com erros que podem ocorrer durante a execução do código.
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon)) //cria uma nova conexão com banco
                {
                    cn.Open(); //Abre a conexão com o banco de dados. Sem isso, não é possível executar comandos SQL
                    var sql = "INSERT INTO estagiarios (nomeEstagiario, nomeSocialEstagiario, enderecoEstagiario, cepEstagiario, cidadeEstagiario, telEstagiario, dataNasciEstagiario, nomeFaculEstagiario, periodoFaculEstagiario) VALUES (@nomeEstagiario, @nomeSocialEstagiario, @enderecoEstagiario, @cepEstagiario, @cidadeEstagiario, @telEstagiario, @dataNasciEstagiario, @nomeFaculEstagiario, @periodoFaculEstagiario)";
                    //Define a consulta SQL que será executada.
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    //Cria um objeto SqlCommand que representa o comando SQL a ser executado.
                    {
                        //Adiciona os valores dos parâmetros ao comando SQL. Cada parâmetro é associado a um valor obtido dos controles do formulário (txtNome.Text, txtData.Text, etc)
                        cmd.Parameters.AddWithValue("@nomeEstagiario", txtNomeEstagiarios.Text);
                        cmd.Parameters.AddWithValue("@nomeSocialEstagiario", txtNomeSocial.Text);
                        cmd.Parameters.AddWithValue("@enderecoEstagiario", txtEnderecoEstagiario.Text);
                        cmd.Parameters.AddWithValue("@cepEstagiario", txtCepEstagiarios.Text);
                        cmd.Parameters.AddWithValue("@cidadeEstagiario", txtCidadeEstagiarios.Text);
                        cmd.Parameters.AddWithValue("@telEstagiario", txtTelefoneEstagiarios.Text);
                        cmd.Parameters.AddWithValue("@dataNasciEstagiario", txtDataNascEstagio.Text);
                        cmd.Parameters.AddWithValue("@nomeFaculEstagiario", txtNomeFaculdade.Text);
                        cmd.Parameters.AddWithValue("@periodoFaculEstagiario", txtPeriodoFaculdade.Text);
                        cmd.ExecuteNonQuery(); //Executa o comando SQL no banco de dados

                        MessageBox.Show("Salvo com sucesso"); //Se o comando SQL for executado com sucesso, uma mensagem é exibida ao usuário

                    }
                }
            }

            //Se ocorrer algum erro durante a execução do código no bloco try, o controle será passado para o bloco catch.
            catch (Exception ex) //Exception ex: Captura a exceção gerada.

            {
                MessageBox.Show("Dados não salvos.\n\n" + ex.Message); //Exibe uma mensagem de erro ao usuário, incluindo a mensagem de exceção (ex.Message)
            }
        }
    }
}
        
    

