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
    public partial class CadastrodeAluno: Form
    {
        int idAluno = 0;
        public CadastrodeAluno(int idAluno)
        {
            InitializeComponent();
            this.idAluno = idAluno;
            if (this.idAluno > 0) ;
            GetAluno(idAluno);
        }
        private void GetAluno(int idAluno)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from alunos where idAluno=" + idAluno;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtNomeAluno.Text = dr["nomeAluno"].ToString();
                                    txtNomeSocial.Text = dr["nomeSocialAluno"].ToString();
                                    txtEnderecoAluno.Text = dr["enderecoAluno"].ToString();
                                    txtCepAluno.Text = dr["cepAluno"].ToString();
                                    txtCidadeAluno.Text = dr["cidadeAluno"].ToString();
                                    txtTelefonePaisAluno.Text = dr["telefonePaisAluno"].ToString();
                                    txtTelefoneAluno.Text = dr["telefoneAluno"].ToString();
                                    txtEmailPaisAluno.Text = dr["emailPaisAluno"].ToString();
                                    txtEmailAluno.Text = dr["emailAluno"].ToString();
                                    txtDataNascAluno.Text = dr["dataNascAluno"].ToString();
                                    txtRgAluno.Text = dr ["rgAluno"].ToString();
                                    txtCpfAluno.Text = dr["cpfAluno"].ToString();
                                    txtSexoAluno.Text = dr["sexoAluno"].ToString();
                                    txtCidAluno.Text = dr["cidAluno"].ToString();
                                    txtDescricaoCidAluno.Text = dr["descricaoCidAluno"].ToString();










                                }
                            }
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Dados não atualizados.\n\n" + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
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
                        cmd.Parameters.AddWithValue("@nomeAluno", txtNomeAluno.Text);
                        cmd.Parameters.AddWithValue("@nomeSocialAluno", txtNomeSocial.Text);
                        cmd.Parameters.AddWithValue("@enderecoAluno", txtEnderecoAluno.Text);
                        cmd.Parameters.AddWithValue("@cepAluno", txtCepAluno.Text);
                        cmd.Parameters.AddWithValue("@cidadeAluno", txtCidadeAluno.Text);
                        cmd.Parameters.AddWithValue("@telPaisAluno", txtTelefonePaisAluno.Text);
                        cmd.Parameters.AddWithValue("@telAluno", txtTelefoneAluno.Text);
                        cmd.Parameters.AddWithValue("@emailPaisAluno", txtEmailPaisAluno.Text);
                        cmd.Parameters.AddWithValue("@emailAluno", txtEmailAluno.Text);
                        cmd.Parameters.AddWithValue("@dataNascAluno", txtDataNascAluno.Text);
                        cmd.Parameters.AddWithValue("@rgAluno", txtRgAluno.Text);
                        cmd.Parameters.AddWithValue("@cpfAluno", txtCpfAluno.Text);
                        cmd.Parameters.AddWithValue("@sexoAluno", txtSexoAluno.Text);
                        cmd.Parameters.AddWithValue("@cidAluno", txtCidAluno.Text);
                        cmd.Parameters.AddWithValue("@descricaoCidAluno", txtDescricaoCidAluno.Text);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscadeAluno frm = new frmBuscadeAluno();
            frm.ShowDialog();
        }
    }
    }

