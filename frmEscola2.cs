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
    public partial class frmEscola2: Form
    {
        int idEscola = 0;
        public frmEscola2(int idEscola)
        {
            InitializeComponent();

            this.idEscola = idEscola;

            if (this.idEscola > 0)
                GetEscola(idEscola);
            
        }

        private void GetEscola(int idEscola)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from escolas where idEscolas=" + idEscola;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtNomeEscolas.Text = dr["nomeEscola"].ToString();
                                    txtEnderecoEscolas.Text = dr["enderecoEscola"].ToString();
                                    txtCepEscolas.Text = dr["cepEscola"].ToString();
                                    txtTelefoneEscolas.Text = dr["telEscola"].ToString();
                                    txtDiretoraEscolas.Text = dr["diretoraEscola"].ToString();
                                    txtCoordEscolas.Text = dr["coordenadoraEscola"].ToString();


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





        private void btnSalvarEscola_Click(object sender, EventArgs e)
        { 
            //os blocos try e catch são usados para tratamento de exceções, ou seja, para lidar com erros que podem ocorrer durante a execução do código.
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon)) //cria uma nova conexão com banco
                {
                    cn.Open(); //Abre a conexão com o banco de dados. Sem isso, não é possível executar comandos SQL
                    var sql = "INSERT INTO escolas (nomeEscola, enderecoEscola, cepEscola, cidadeEscola, telEscola, diretoraEscola, coordenadoraEscola) VALUES (@nomeEscola, @enderecoEscola, @cepEscola, @cidadeEscola, @telEscola, @diretoraEscola, @coordenadoraEscola)";
                    //Define a consulta SQL que será executada.
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    //Cria um objeto SqlCommand que representa o comando SQL a ser executado.
                    {
                        //Adiciona os valores dos parâmetros ao comando SQL. Cada parâmetro é associado a um valor obtido dos controles do formulário (txtNome.Text, txtData.Text, etc)
                        cmd.Parameters.AddWithValue("@nomeEscola", txtNomeEscolas.Text);
                        cmd.Parameters.AddWithValue("@enderecoEscola", txtEnderecoEscolas.Text);
                        cmd.Parameters.AddWithValue("@cepEscola", txtCepEscolas.Text);
                        cmd.Parameters.AddWithValue("@cidadeEscola", txtCidadeEscolas.Text);
                        cmd.Parameters.AddWithValue("@telEscola", txtTelefoneEscolas.Text);
                        cmd.Parameters.AddWithValue("@diretoraEscola", txtDiretoraEscolas.Text);
                        cmd.Parameters.AddWithValue("@coordenadoraEscola", txtCoordEscolas.Text);
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

        

        private void btnBuscarEscola_Click(object sender, EventArgs e)
        {
            frmBuscadeEscola frm = new frmBuscadeEscola();
            frm.ShowDialog();
        }

        private void btnSairEscolas_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal frm = new frmMenuPrincipal();
            frm.ShowDialog();
        }
    }
}
