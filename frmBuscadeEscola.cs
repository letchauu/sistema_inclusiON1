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
    public partial class frmBuscadeEscola : Form
    {
        private object idEscola;

        public frmBuscadeEscola()
        {
            InitializeComponent();
        }

        private void btnBuscarEscolas_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                    {
                        cn.Open();

                        var sqlQuery = "select * from escolas";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())

                            {
                                da.Fill(dt);
                                dgvBuscadeEscolas.DataSource = dt;
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

        private void btnSairBuscaEscolas_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirEscola_Click(object sender, EventArgs e)
        {
            if (dgvBuscadeEscolas.SelectedRows.Count > 0)
            {
                //pega o idAluno da linha selecionada
                int idEscolas = Convert.ToInt32(dgvBuscadeEscolas.SelectedRows[0].Cells["idEscolas"].Value);

                var confirm = MessageBox.Show("Tem certeza que deseja excluir essa escola?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM escolas WHERE idEscolas = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idEscolas);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Escola excluída com sucesso!");
                                BuscarNovamente(); //regarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir escola.\n\n" + ex.Message);
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
                    var sqlQuery = "select * from escolas where nomeEscola like '%" + txtBuscarEscolas.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscadeEscolas.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados.\n\n" + ex.Message);
            }
        }
        private void btnEditarEscola_Click(object sender, EventArgs e)
        {
           if (dgvBuscadeEscolas.SelectedRows.Count > 0)
            {
                // Pega o ID da escola selecionada
                int idEscola = Convert.ToInt32(dgvBuscadeEscolas.SelectedRows[0].Cells["idEscolas"].Value);

                // Abre o formulário de cadastro com os dados da escola
                frmEscola2 frm = new frmEscola2(idEscola);
                frm.ShowDialog();

                // Atualiza a lista após edição
                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione uma escola para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
        
    

