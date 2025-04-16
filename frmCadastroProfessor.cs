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
    public partial class frmCadastroProfessor: Form
    {
        int idProfessor = 0;
        public frmCadastroProfessor(int idProfessor)
        {
            InitializeComponent();
            this.idProfessor = idProfessor;

            if (this.idProfessor > 0) ;
            GetProfessor(idProfessor);
        }
        private void GetProfessor(int idProfessor)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from professores where idProfessor=" + idProfessor;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtNomeProfessor.Text = dr["nomeProfessor"].ToString();
                                    txtNomeSocial.Text = dr["nomeSocialProfessor"].ToString();
                                    txtEnderecoProfessor.Text = dr["enderecoProfessor"].ToString();
                                    txtCepProfessor.Text = dr["cepProfessor"].ToString();
                                    txtCidadeProfessor.Text = dr["cidadeProfessor"].ToString();
                                    txtTelefoneProfessor.Text = dr["telefoneProfessor"].ToString();
                                    txtCertificadoProfessor.Text = dr["certificadoProfessor"].ToString();

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

        private void btnSalvarProfessor_Click(object sender, EventArgs e)
        {
            //os blocos try e catch são usados para tratamento de exceções, ou seja, para lidar com erros que podem ocorrer durante a execução do código.
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon)) //cria uma nova conexão com banco
                {
                    cn.Open(); //Abre a conexão com o banco de dados. Sem isso, não é possível executar comandos SQL
                    var sql = "INSERT INTO professores (nomeProfessor, nomeSocialProfessor, enderecoProfessor, cepProfessor, cidadeProfessor, telProfessor, certificadoProfessor) VALUES (@nomeProfessor, @nomeSocialProfessor, @enderecoProfessor, @cepProfessor, @cidadeProfessor, @telProfessor, @certificadoProfessor)";
                    //Define a consulta SQL que será executada.
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    //Cria um objeto SqlCommand que representa o comando SQL a ser executado.
                    {
                        //Adiciona os valores dos parâmetros ao comando SQL. Cada parâmetro é associado a um valor obtido dos controles do formulário (txtNome.Text, txtData.Text, etc)
                        cmd.Parameters.AddWithValue("@nomeProfessor", txtNomeProfessor.Text);
                        cmd.Parameters.AddWithValue("@nomeSocialProfessor", txtNomeSocial.Text);
                        cmd.Parameters.AddWithValue("@enderecoProfessor", txtEnderecoProfessor.Text);
                        cmd.Parameters.AddWithValue("@cepProfessor", txtCepProfessor.Text);
                        cmd.Parameters.AddWithValue("@cidadeProfessor", txtCidadeProfessor.Text);
                        cmd.Parameters.AddWithValue("@telProfessor", txtTelefoneProfessor.Text);
                        cmd.Parameters.AddWithValue("@certificadoProfessor", txtCertificadoProfessor.Text);
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
            frmBuscadeProfessores frm = new frmBuscadeProfessores();
            frm.ShowDialog();
        }

        private void btnSairProfessor_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            frm.ShowDialog();
        }
    }
}
    

