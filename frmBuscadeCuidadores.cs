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
    public partial class frmBuscadeCuidadores: Form
    {
        public frmBuscadeCuidadores()
        {
            InitializeComponent();
        }

        private void btnBuscarCuidador_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                    {
                        cn.Open();

                        var sqlQuery = "select * from cuidadores";
                        using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                        {
                            using (DataTable dt = new DataTable())

                            {
                                da.Fill(dt);
                                dgvBuscarCuidador.DataSource = dt;
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

        private void btnSairBuscaCuidador_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvBuscarCuidador.SelectedRows.Count > 0)
            {

                int idCuidador = Convert.ToInt32(dgvBuscarCuidador.SelectedRows[0].Cells["idCuidador"].Value);


                frmCuidadores frm = new frmCuidadores(idCuidador);
                frm.ShowDialog();


                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione um cuidador para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvBuscarCuidador.SelectedRows.Count > 0)
            {
                
                int idCuidador = Convert.ToInt32(dgvBuscarCuidador.SelectedRows[0].Cells["idCuidador"].Value);

                var confirm = MessageBox.Show("Tem certeza que deseja excluir esse cuidador?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM cuidadores WHERE idCuidador = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idCuidador);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Cuidador excluído com sucesso!");
                                BuscarNovamente(); //regarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir cuidador.\n\n" + ex.Message);
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
                    var sqlQuery = "select * from cuidadores where nomeCuidador like '%" + txtBuscarCuidador.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvBuscarCuidador.DataSource = dt;
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

        
    
    
    

