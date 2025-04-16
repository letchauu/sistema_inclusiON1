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
    public partial class frmCadastrodeUsuario: Form
    {
        int idUsuario = 0;
        public frmCadastrodeUsuario(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;

            if (this.idUsuario > 0) ;
            GetUsuario(idUsuario);
        }
        private void GetUsuario(int idUsuario)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from usuarios where idUsuario=" + idUsuario;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtNomeUsuario.Text = dr["nomeUsuario"].ToString();
                                    txtEmailUsuario.Text = dr["emailUsuario"].ToString();
                                    txtSenhaUsuario.Text = dr["senhaUsuario"].ToString();
                                    txtLogin.Text = dr["loginUsuario"].ToString();
                                    

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

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            //os blocos try e catch são usados para tratamento de exceções, ou seja, para lidar com erros que podem ocorrer durante a execução do código.
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon)) //cria uma nova conexão com banco
                {
                    cn.Open(); //Abre a conexão com o banco de dados. Sem isso, não é possível executar comandos SQL
                    var sql = "INSERT INTO usuarios (nomeUsuario, emailUsuario, senhaUsuario, loginUsuario) VALUES (@nomeUsuario, @emailUsuario, @senhaUsuario, @loginUsuario)";
                    //Define a consulta SQL que será executada.
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    //Cria um objeto SqlCommand que representa o comando SQL a ser executado.
                    {
                        //Adiciona os valores dos parâmetros ao comando SQL. Cada parâmetro é associado a um valor obtido dos controles do formulário (txtNome.Text, txtData.Text, etc)
                        cmd.Parameters.AddWithValue("@nomeUsuario", txtNomeUsuario.Text);
                        cmd.Parameters.AddWithValue("@emailUsuario", txtEmailUsuario.Text);
                        cmd.Parameters.AddWithValue("@senhaUsuario", txtSenhaUsuario.Text);
                        cmd.Parameters.AddWithValue("@loginUsuario", txtLogin.Text);
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

        private void btnSairUsuario_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            frm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscadeUsuario frm = new frmBuscadeUsuario();
            frm.ShowDialog();
        }
    }
    }

