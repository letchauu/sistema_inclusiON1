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
    public partial class frmCadastrodeAlunoLaudado: Form
    {
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
            using (SqlConnection cn = new SqlConnection(conectionString))
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
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("select idEscola, nomeEscola from escolas", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbNomeEscola.Items.Add(new ComboboxItem
                    {
                        Text = reader["nomeEscola"].ToString(),
                        Value = reader["idEscola"]
                    });
                }
            }
        }

        private void CarregarProfessor()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
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
        }
    }

