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
    public partial class frmBuscadeProfessores: Form
    {
        public frmBuscadeProfessores()
        {
            InitializeComponent();
        }

        private void btnBuscarProfessor_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                    {
                        cn.Open();

                        var sqlQuery = "select * from professores";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())

                            {
                                da.Fill(dt);
                                dgvBuscadeProfessor.DataSource = dt;
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

        private void btnSairBuscaProfessor_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditarBusca_Click(object sender, EventArgs e)
        {
            if (dgvBuscadeProfessor.SelectedRows.Count > 0)
            {
                
                int idProfessor = Convert.ToInt32(dgvBuscadeProfessor.SelectedRows[0].Cells["idProfessor"].Value);

                
                frmCadastroProfessor frm = new frmCadastroProfessor(idProfessor);
                frm.ShowDialog();

                
                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione um professor para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvBuscadeProfessor.SelectedRows.Count > 0)
            {
                //pega o idAluno da linha selecionada
                int idProfessor = Convert.ToInt32(dgvBuscadeProfessor.SelectedRows[0].Cells["idProfessor"].Value);

                var confirm = MessageBox.Show("Tem certeza que deseja excluir esse professor(a)?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM professores WHERE idProfessor = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idProfessor);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Professor(a) excluído(a) com sucesso!");
                                BuscarNovamente(); //regarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir professor(a).\n\n" + ex.Message);
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
                    var sqlQuery = "select * from professores where nomeProfessor like '%" + txtBuscarProfessor.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscadeProfessor.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados.\n\n" + ex.Message);
            }
        }
    }
    }

        
        
 

