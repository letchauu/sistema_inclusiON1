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
    public partial class frmAlunos: Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarAlunos_Click(object sender, EventArgs e)
        {
            //os blocos try e catch são usados para tratamento de exceções, ou seja, para lidar com erros que podem ocorrer durante a execução do código.
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon)) //cria uma nova conexão com banco
                {
                    cn.Open(); //Abre a conexão com o banco de dados. Sem isso, não é possível executar comandos SQL
                    var sql = "INSERT INTO alunos (nomeAluno, nomeSocialAluno, enderecoAluno, cepAluno, cidadeAluno, telPaisAluno, telAluno, emailPaisAluno, emailAluno, dataNascAluno, rgAluno, cpfAluno, sexoAluno, cidAluno, descricaoCidAluno) VALUES (@nomeAluno, @nomeSocialAluno, @enderecoAluno, @cepAluno, @cidadeAluno, @telPaisAluno, @telAluno, @emailPaisAluno, @emailAluno, @dataNascAluno, @rgAluno, @cpfAluno, @sexoAluno, @cidAluno, @descricaoCidAluno)";
                    //Define a consulta SQL que será executada.
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    //Cria um objeto SqlCommand que representa o comando SQL a ser executado.
                    {
                        //Adiciona os valores dos parâmetros ao comando SQL. Cada parâmetro é associado a um valor obtido dos controles do formulário (txtNome.Text, txtData.Text, etc)
                        cmd.Parameters.AddWithValue("@nomeAluno", txtNomeAlunos.Text);
                        cmd.Parameters.AddWithValue("@nomeSocialAluno", txtNomeSocial.Text);
                        cmd.Parameters.AddWithValue("@enderecoAluno", txtEndereco.Text);
                        cmd.Parameters.AddWithValue("@cepAluno", txtCep.Text);
                        cmd.Parameters.AddWithValue("@cidadeAluno", txtCidade.Text);
                        cmd.Parameters.AddWithValue("@telPaisAluno", txtTelefonePais.Text);
                        cmd.Parameters.AddWithValue("@telAluno", txtTelefoneAluno.Text);
                        cmd.Parameters.AddWithValue("@emailPaisAluno", txtEmailPais.Text);
                        cmd.Parameters.AddWithValue("@emailAluno", txtEmailAluno.Text);
                        cmd.Parameters.AddWithValue("@dataNascAluno", txtDataNasc.Text);
                        cmd.Parameters.AddWithValue("@rgAluno", txtRG.Text);
                        cmd.Parameters.AddWithValue("@cpfAluno", txtCpf.Text);
                        cmd.Parameters.AddWithValue("@sexoAluno", txtSexo.Text);
                        cmd.Parameters.AddWithValue("@cidAluno", txtCid.Text);
                        cmd.Parameters.AddWithValue("@descricaoCidAluno", txtDescricao.Text);
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

