using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_inclusiON
{
    public partial class frmCadastrodeAlunoLaudado: Form
    {
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public frmCadastrodeAlunoLaudado()
        {
            InitializeComponent();
            CarregarAlunos();
            CarregarEscolas();
            CarregarProfessor();
            CarregarEstagiarios();
            CarregarCuidador();
            CarregarUsuarios();
        }

        private void CarregarAlunos()
        {
            using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idAluno, nomeAluno from alunos", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbNomeAluno.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeAluno"].ToString(),
                        Value = reader["idAluno"]
                    });
                }
            }
        }


        private void CarregarEscolas()
        {
            using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idEscolas, nomeEscola from escolas", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbNomeEscola.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeEscola"].ToString(),
                        Value = reader["idEscolas"]
                    });
                }
            }
        }

        private void CarregarProfessor()
        {
            using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idProfessor, nomeProfessor from professores", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbNomeProfessor.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeProfessor"].ToString(),
                        Value = reader["idProfessor"]
                    });
                }
            }
        }

        private void CarregarEstagiarios()
        {
            using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idEstagiario, nomeEstagiario from estagiarios", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbNomeEstagiario.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeEstagiario"].ToString(),
                        Value = reader["idEstagiario"]
                    });
                }

            }
        }

        private void CarregarCuidador()
        {
            using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idCuidador, nomeCuidador from cuidadores", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbNomeCuidador.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeCuidador"].ToString(),
                        Value = reader["idCuidador"]
                    });
                }

            }
        }

        private void CarregarUsuarios()
        {
            using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idUsuario, nomeUsuario from usuarios", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbUsuario.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeUsuario"].ToString(),
                        Value = reader["idUsuario"]
                    });
                }
            }
        }

        private void btnSalvarCadastro_Click(object sender, EventArgs e)
        
        {
            int idAluno = (int)(cmbNomeAluno.SelectedItem as ComboboxItem).Value;
            string nomeSocialAluno = txtNomeSocial.ToString();
            int idEscola = (int)(cmbNomeEscola.SelectedItem as ComboboxItem).Value;
            int idProfessor = (int)(cmbNomeProfessor.SelectedItem as ComboboxItem).Value;
            int idCuidador = (int)(cmbNomeCuidador.SelectedItem as ComboboxItem).Value;
            int idEstagiario = (int)(cmbNomeEstagiario.SelectedItem as ComboboxItem).Value;
            string desenAluno = txtDesenAluno.ToString();
            int idUsuario = (int)(cmbUsuario.SelectedItem as ComboboxItem).Value;
            

            using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO cadastro (idAluno, nomeSocialAluno, idEscola, idProfessor, idCuidador, idEstagiario, desenvolvimentoAluno, idUsuario) VALUES (@idAluno, @nomeSocialAluno, @idEscola, @idProfessor, @idCuidador, @idEstagiario, @desenvolvimentoAluno, @idUsuario)", cn);
                cmd.Parameters.AddWithValue("@idAluno", idAluno);
                cmd.Parameters.AddWithValue("@nomeSocialAluno", nomeSocialAluno);
                cmd.Parameters.AddWithValue("@idEscola", idEscola);
                cmd.Parameters.AddWithValue("@idProfessor", idProfessor);
                cmd.Parameters.AddWithValue("@idCuidador", idCuidador);
                cmd.Parameters.AddWithValue("@idEstagiario", idEstagiario);
                cmd.Parameters.AddWithValue("@desenvolvimentoAluno", desenAluno);
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Matrícula realizada com sucesso!");
        }

        
        

        }
    }

