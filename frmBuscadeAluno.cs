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
    public partial class frmBuscadeAluno : Form
    {
        public frmBuscadeAluno()
        {
            InitializeComponent();
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                    {
                        cn.Open();

                        var sqlQuery = "select * from alunos";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())

                            {
                                da.Fill(dt);
                                dgvBuscadeAluno.DataSource = dt;
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);


                }
            }
        }

        private void btnSairBuscaAluno_Click(object sender, EventArgs e)
        {
            frmBuscadeAluno frm = new frmBuscadeAluno();
            frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvBuscadeAluno.SelectedRows.Count > 0)
            {
                //pega o idAluno da linha selecionada
                int idAluno = Convert.ToInt32(dgvBuscadeAluno.SelectedRows[0].Cells["idAluno"].Value);

                var confirm = MessageBox.Show("Tem certeza que deseja excluir esse aluno?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM alunos WHERE idAluno = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idAluno);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Aluno excluído com sucesso!");
                                BuscarNovamente(); //regarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir aluno.\n\n" + ex.Message);
                    }
                }
            }
        }

        private void BuscarNovamente()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sqlQuery = "select * from alunos where nomeAluno like '%" + txtBuscarAluno.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscadeAluno.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados.\n\n" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (dgvBuscadeAluno.SelectedRows.Count > 0)
            {
                //Pega o id do aluno selecionado 
                int idAluno = Convert.ToInt32(dgvBuscadeAluno.SelectedRows[0].Cells["idAluno"].Value);

                //Abre o formulário de cadastro com os dados do aluno
                CadastrodeAluno frm = new CadastrodeAluno(idAluno);
                frm.ShowDialog();

                //Atualiza a lista após edição
                BuscarNovamente();

            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            }
        }
    }

    

